using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases.Producto
{
    public class GestionProducto
    {
        public static List<Producto> getProducts()
        {
            List<Producto> respuesta = new List<Producto>();
            try
            {
                string query = $@"SELECT idProducto, Nombre, Descripcion, Stock, Precio, idTipo FROM Productos";
                respuesta = DatabaseConnection.executeNonQueryDT(query).ToListProducto();
                return respuesta;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return new List<Producto>();
        }
    }
}