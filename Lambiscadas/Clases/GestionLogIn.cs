using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases
{
    public class GestionLogIn
    {

        public static string LogInUsuario(string email, string password)
        {
            string respuesta = "-1";
            try
            {
                string query = $@"SELECT TOP 1 idUsuario FROM Usuarios WHERE Email = '{email}' AND Password = '{password}'";
                int idUsuario = DatabaseConnection.executeScalarInt(query, CommandType.Text, ConnectionString.Lambiscadas);
                if(idUsuario > 0)
                {
                    string token = idUsuario + "I" + Guid.NewGuid().ToString();
                    if (Utilities.updateGuid(idUsuario, token))
                    {
                        Basico.crearCookie("token", token);
                        //HttpContext.Current.Response.Redirect("../Home/home.aspx", false); //CAMBIAR, NO FUNCA
                        respuesta = "1";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return respuesta;
        }

    }
}