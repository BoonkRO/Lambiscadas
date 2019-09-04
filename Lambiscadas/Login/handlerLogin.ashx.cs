using Lambiscadas.Clases;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambiscadas.Login
{
    /// <summary>
    /// Descripción breve de handlerLogin
    /// </summary>
    public class handlerLogin : IHttpHandler
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
                    case "getDatosLogin":
                        string email = Utilities.getParam(context, "Email");
                        string password = Utilities.getParam(context, "Password");
                        respuesta += GestionLogIn.LogInUsuario(email, password);
                        break;
                }

                context.Response.ContentType = "text/plain";
                context.Response.Write(respuesta);
            //}
        }

        private string parseToken(String tokenUsuario)
        {
            String token = tokenUsuario;
            if (token.Contains("token=id="))
            {
                token = token.Replace("token=id=", "");
            }
            if (token.Contains("id="))
            {
                token = token.Replace("id=", "");
            }
            return token;
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