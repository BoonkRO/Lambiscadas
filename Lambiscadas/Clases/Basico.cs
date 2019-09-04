using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Lambiscadas.Clases
{
    public class Basico
    {

        internal static void crearCookie(string tokenUsuario)
        {
            if (!string.IsNullOrEmpty(tokenUsuario) && tokenUsuario.Split('I').Length > 0)
            {
                int idUsuario = Convert.ToInt32(tokenUsuario.Split('I')[0]);
                HttpResponse Response = HttpContext.Current.Response;

                HttpContext.Current.Session["sToken"] = tokenUsuario;

                HttpCookie token = new HttpCookie("token");

                if (!Utilities.isLocalHost())
                {
                    token.HttpOnly = true;
                    token.Secure = true;
                }

                token.Value = tokenUsuario;

                token.Expires = DateTime.Now.AddHours(6d);
                Response.Cookies.Add(token);

                //Utilities.addEvento("Login usuario", "Cookie de usuario creada. Token: " + tokenUsuario, idUsuario.ToString());
            }
        }

        internal static void crearCookie(string key, string value)
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(key))
            {

                HttpResponse Response = HttpContext.Current.Response;
                HttpCookie cookie = new HttpCookie(key);

                if (!Utilities.isLocalHost())
                {
                    cookie.HttpOnly = true;
                    cookie.Secure = true;
                }
                cookie.Value = value;
                cookie.Expires = DateTime.Now.AddHours(1d);
                Response.Cookies.Add(cookie);
            }
        }

        internal static void loginUsuario(string Email, string Password)
        {
            try
            {
                string query = $@"SELECT idUsuario FROM Usuarios WHERE Email = '{Email}' AND Password = '{Password}'";
                int idUsuario = DatabaseConnection.executeScalarInt(query, CommandType.Text, ConnectionString.Lambiscadas);
                if (idUsuario > 0)
                {
                    string token = Guid.NewGuid().ToString();
                    if (Utilities.updateGuid(idUsuario, token))
                    {
                        HttpContext.Current.Response.Redirect("../Home/home.aspx");
                    }
                }

            }
            catch (Exception e)
            {

            }
        }


    }
}