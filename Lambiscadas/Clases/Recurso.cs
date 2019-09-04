using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases
{
    public static class Recurso
    {

        public static string DataTabletoJSONObject(this DataTable dt)
        {
            string respuesta = "";

            try
            {
                if (dt.Rows.Count > 0)
                {
                    JObject devolver = new JObject();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            devolver.Add(col.ToString(), dr[col].ToString());
                        }
                    }
                    respuesta = devolver.ToString();
                }
            }
            catch (Exception e)
            {
                respuesta = "";
            }
            return respuesta;
        }


        //Convert dt to JSON Object List
        public static List<Producto.Producto> ToListProducto(this DataTable dt)
        {
            var respuesta = new List<Producto.Producto>();
            try
            {
                if (dt.Rows.Count > 0)
                {
                    respuesta = (from rw in dt.AsEnumerable()
                                 select new Producto.Producto()
                                 {
                                     idProducto = rw.getInt("idProducto"),
                                     Nombre = rw.getString("Nombre"),
                                     Descripcion = rw.getString("Descripcion"),
                                     Stock = rw.getInt("Stock"),
                                     Precio = rw.getFloat("Precio"),
                                     idTipo = rw.getInt("idTipo")
                                 }).ToList();
                }
            }
            catch (Exception e)
            {
                respuesta = new List<Producto.Producto>();
            }
            return respuesta;
        }


    }
}