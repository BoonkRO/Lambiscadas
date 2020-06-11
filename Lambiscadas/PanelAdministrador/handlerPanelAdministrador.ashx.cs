using Lambiscadas.Clases;
using Lambiscadas.Clases.PanelAdministrador;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambiscadas.PanelAdminstrador
{
    /// <summary>
    /// Descripción breve de handlerPanelAdministrador
    /// </summary>
    public class handlerPanelAdministrador : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string tokenUsuario = Utilities.getParam(context, "token");
            //tokenUsuario = parseToken(tokenUsuario);
            string op = Utilities.getParam(context, "op");
            int usuarioValido = -1;
            string respuesta = "";
            //string idUsuario = tokenUsuario.Split('I')[0];

            //usuarioValido = Utilities.comprobarValidezUsuario(tokenUsuario);

            //if (usuarioValido == 1)
            //{
            switch (op)
            {
                case "GuardarNuevosValores":
                    string idProducto = Utilities.getParam(context, "idProducto");
                    string NuevoNombre = Utilities.getParam(context, "NuevoNombre");
                    string NuevoPrecio = Utilities.getParam(context, "NuevoPrecio");
                    string NuevoStock = Utilities.getParam(context, "NuevoStock");
                    respuesta += GestionPanelAdministrador.GuardarNuevosValoresProducto(idProducto, NuevoNombre, NuevoPrecio, NuevoStock);
                    break;
                case "EliminarProducto":
                    string idProductoEliminar = Utilities.getParam(context, "idProducto");
                    respuesta += GestionPanelAdministrador.EliminarProducto(idProductoEliminar);
                    break;
                case "CargarProductos":
                    respuesta += JsonConvert.SerializeObject(GestionPanelAdministrador.CargarProductosEnBBDD());
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