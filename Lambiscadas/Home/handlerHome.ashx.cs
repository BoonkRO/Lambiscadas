using Lambiscadas.Clases;
using Lambiscadas.Clases.Producto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambiscadas.Home
{
    /// <summary>
    /// Descripción breve de handlerHome
    /// </summary>
    public class handlerHome : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = Utilities.getParam(context, "op");
            string respuesta = "";

            switch (op)
            {

                case "getProducts":
                    //Producto producto = ;
                    respuesta += JsonConvert.SerializeObject(GestionProducto.getProducts());
                    break;
            }

            context.Response.ContentType = "text/plain";
            context.Response.Write(respuesta);
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