using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases.Producto
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public float Precio { get; set; }
        public int idTipo { get; set; }


        public Producto()
        {
            //EMPTY
        }

        public Producto(int idProducto, string Nombre, string Descripcion, int Stock, float Precio, int idTipo)
        {
            this.idProducto = idProducto;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Stock = Stock;
            this.Precio = Precio;
            this.idTipo = idTipo;
        }


        //public void ObtenerProducto(int idProducto)
        //{
        //    try
        //    {
        //        string query = $@"SELECT idProducto, Nombre, Descripcion, Stock, Precio, idTipo FROM Productos WHERE idProducto = {idProducto}";
        //        DataTable dt = DatabaseConnection.executeNonQueryDT(query);

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //}
    }
}