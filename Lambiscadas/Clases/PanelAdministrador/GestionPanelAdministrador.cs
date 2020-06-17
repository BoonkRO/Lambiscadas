using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases.PanelAdministrador
{
    public class GestionPanelAdministrador
    {
        public static string GuardarNuevosValoresProducto(string idProducto, string Nombre, string Precio, string Stock)
        {
            string query = $@"UPDATE Productos SET Nombre = '{Nombre}', Precio = {Precio}, Stock = {Stock} WHERE idProducto = {idProducto}";
            int respuesta = DatabaseConnection.executeNonQueryInt(query);
            if(respuesta > 0)
            {
                return "1";
            }

            return "-1";
        }

        public static string EliminarProducto(string idProducto)
        {
            string query = $@"UPDATE Productos SET Activo = 0 WHERE idProducto = {idProducto}";
            int respuesta = DatabaseConnection.executeNonQueryInt(query);
            if (respuesta > 0)
            {
                return "1";
            }

            return "-1";
        }

        public static List<Producto.Producto> CargarProductosEnBBDD()
        {
            string query = $@"SELECT * FROM Productos WHERE Activo = 1";
            List<Producto.Producto> respuesta = DatabaseConnection.executeNonQueryDT(query).ToListProducto();

            return respuesta;
        }

        public static string AnadirNuevoProducto(string Nombre, string Precio, string Stock, string Imagen)
        {
            int Activo = 0;
            if(Convert.ToInt32(Stock) > 0)
            {
                Activo = 1;
            }
            string query = $@"INSERT INTO Productos OUTPUT INSERTED.idProducto VALUES('{Nombre}', '{Nombre}', {Stock}, '{Precio}', 1, {Activo})";
            int idProducto = DatabaseConnection.executeScalarInt(query);

            if(idProducto > 0)
            {
                string folderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory)) + "imgs\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                var bytes = Convert.FromBase64String(Imagen);

                Image image = Image.FromStream(new MemoryStream(bytes));
                Image imgResize = ResizeImage(image, 270, 270);
                using (imgResize)
                {
                    image.Save(folderPath + idProducto + ".jpg");
                    return "1";
                }
            }

            return "-1";
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

    }
}