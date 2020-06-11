using System;
using System.Collections.Generic;
using System.Data;
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

    }
}