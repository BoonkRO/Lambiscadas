using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambiscadas.Producto
{
    /// <summary>
    /// Descripción breve de handlerProducto
    /// </summary>
    public class handlerProducto : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}