using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;

namespace Lambiscadas.Clases
{
    public class Utilities
    {
        public static string getParam(HttpRequest c, string s)
        {
            string parametro = "";
            try
            {
                if (!string.IsNullOrEmpty(c[s]))
                {
                    parametro = WebUtility.HtmlDecode(c[s]);

                    if (s == "token" && parametro == "undefined")
                    {
                        if (c.Cookies["token"] != null && c.Cookies["token"].Value != null)
                        {
                            parametro = WebUtility.HtmlDecode(c.Cookies["token"].Value.ToString());
                        }
                    }
                    else
                    {
                        //if (parametro == "undefined") parametro = "";


                        if (parametro != null && parametro.Contains("token=id="))
                        {
                            parametro = parametro.Replace("token=id=", "");
                        }

                        if (parametro != null && parametro.Contains("token="))
                        {
                            parametro = parametro.Replace("token=", "");
                        }

                        if (parametro != null && parametro.Contains("id="))
                        {
                            parametro = parametro.Replace("id=", "");
                        }
                    }
                    return tratarParam(parametro);
                }
                else
                {
                    // Si es nulo devuelvo vacío
                    return WebUtility.HtmlDecode(c[s]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }

        public static String getParam(HttpContext c, string s)
        {
            string parametro = "";
            try
            {
                if (!string.IsNullOrEmpty(c.Request[s]))
                {
                    parametro = WebUtility.HtmlDecode(c.Request[s]);

                    if (s == "token" && parametro == "undefined")
                    {
                        if (c.Request.Cookies["token"] != null && c.Request.Cookies["token"].Value != null)
                        {
                            parametro = WebUtility.HtmlDecode(c.Request.Cookies["token"].Value.ToString());
                        }
                    }
                    else
                    {
                        //if (parametro == "undefined") parametro = "";


                        if (parametro != null && parametro.Contains("token=id="))
                        {
                            parametro = parametro.Replace("token=id=", "");
                        }

                        if (parametro != null && parametro.Contains("token="))
                        {
                            parametro = parametro.Replace("token=", "");
                        }

                        if (parametro != null && parametro.Contains("id="))
                        {
                            parametro = parametro.Replace("id=", "");
                        }
                    }
                    return tratarParam(parametro);
                }
                else
                {
                    // Si es nulo devuelvo vacío
                    return WebUtility.HtmlDecode(c.Request[s]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }

        //ELIMINAR POSIBLES CARACTERES QUE HTML INTRODUCE
        public static string tratarParam(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            s = WebUtility.HtmlDecode(s);
            if (s.Contains("--")) s = s.Replace("--", "");
            if (s.Contains("'")) s = s.Replace("'", "");

            // Añado el punto a media altura que nos ha causado problemas con javascript
            if (s.Contains("•")) s = s.Replace("•", "");

            if (s.Contains("\r\n"))
            {
                s = s.Replace("\r\n", Environment.NewLine);
            }
            else
            {
                if (s.Contains("\n")) s = s.Replace("\n", Environment.NewLine);
                else if (s.Contains("\r")) s = s.Replace("\r", Environment.NewLine);
            }

            if (s.Contains("\\")) s = s.Replace("\\", "");
            return s;
        }

        public static bool validezUsuario(HttpRequest hr)
        {
            try
            {

                if ((hr.Cookies["token"] != null) && !string.IsNullOrEmpty(hr.Cookies["token"].Value) && hr.Cookies["token"].Value.Contains('I'))
                {
                    if (hr.Cookies["token"].Value.Contains('='))
                    {
                        string tokenUsuario = Utilities.tratarParam(hr.Cookies["token"].Value.Split('=')[1]);
                        if (Utilities.comprobarValidezUsuario(tokenUsuario) == 1)
                        {
                            int idUsuario = Convert.ToInt32(tokenUsuario.Split('I')[0]);
                            if (idUsuario > 0)
                            {
                                string query = $@"SELECT TOP 1 * FROM Administrador WHERE idAdmin = {idUsuario} AND token = '{Utilities.tratarParam(tokenUsuario.Split('I')[1])}'";
                                DataTable dt = DatabaseConnection.executeNonQueryDT(query, CommandType.Text, ConnectionString.Lambiscadas);
                                if (dt.Rows.Count > 0)
                                {
                                    return true;
                                }

                                //int rol = Convert.ToInt32(DatabaseConnection.executeScalar(query, CommandType.Text, ConnectionString.SomNautic));
                                //if(rol == 1) return true;
                            }
                        }
                    }
                    else
                    {
                        string tokenUsuario = Utilities.tratarParam(hr.Cookies["token"].Value);
                        if (Utilities.comprobarValidezUsuario(tokenUsuario) == 1)
                        {
                            int idUsuario = Convert.ToInt32(tokenUsuario.Split('I')[0]);
                            if (idUsuario > 0)
                            {
                                string query = $@"SELECT TOP 1 * FROM Administrador WHERE idAdmin = {idUsuario} AND token = '{Utilities.tratarParam(tokenUsuario.Split('I')[1])}'";
                                DataTable dt = DatabaseConnection.executeNonQueryDT(query, CommandType.Text, ConnectionString.Lambiscadas);
                                if (dt.Rows.Count > 0)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // En este caso tenemos el token por parámetro en la url
                    // y si hemos llegado a este punto es por que la cookie y la sesión no está creada
                    // La creamos

                    string tokenUsuario = Utilities.getParam(hr, "token");
                    if (Utilities.comprobarValidezUsuario(tokenUsuario) == 1)
                    {
                        int idUsuario = Convert.ToInt32(tokenUsuario.Split('I')[0]);
                        if (idUsuario > 0)
                        {
                            string query = $@"SELECT TOP 1 * FROM Administrador WHERE idAdmin = {idUsuario} AND token = '{Utilities.tratarParam(tokenUsuario.Split('I')[1])}'";
                            int rol = Convert.ToInt32(DatabaseConnection.executeScalar(query, CommandType.Text, ConnectionString.Lambiscadas));
                            if (rol == 1)
                            {
                                Basico.crearCookie(tokenUsuario);
                                return true;
                            }
                        }
                    }

                }

                return false;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static int comprobarValidezUsuario(string tokenUsuario)
        {
            string query = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(tokenUsuario) || tokenUsuario == "undefined" || !tokenUsuario.Contains('I'))
                    return -1;

                if (tokenUsuario.Contains(';')) tokenUsuario = tokenUsuario.Split(';')[0];

                if (tokenUsuario.Contains("token=id=")) tokenUsuario = tokenUsuario.Replace("token=id=", "");
                if (tokenUsuario.Contains("id=")) tokenUsuario = tokenUsuario.Replace("id=", "");

                if (tokenUsuario.Contains('I'))
                {
                    string idUsuario = tokenUsuario.Split('I')[0];

                    string passToken = tokenUsuario.Replace(tokenUsuario.Split('I')[0] + "I", "");
                    if (Convert.ToInt32(idUsuario) > 0)
                    {
                        //query = "SELECT TOP 1 idAdmin FROM Administrador WHERE (token = '" + tokenUsuario + "') AND idAdmin = " + idUsuario + " AND Activo = 1";
                        query = "SELECT TOP 1 idUsuario FROM Usuarios WHERE idUsuario = " + idUsuario + " AND token = '" + tokenUsuario.Split('I')[1] + "'";
                        DataTable dt = DatabaseConnection.executeNonQueryDT(query, CommandType.Text, ConnectionString.Lambiscadas);
                        if (dt.Rows.Count > 0)
                        {
                            return 1;
                        }
                    }
                }
                return -1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        internal static bool isLocalHost()
        {
#if DEBUG
            return true;
#endif
            return false;
        }

        public static bool updateGuid(int idUsuario, string guid)
        {
            try
            {
                string query = $@"UPDATE Usuarios SET token='{guid}' WHERE idUsuario={idUsuario}";
                return (DatabaseConnection.executeNonQueryInt(query, CommandType.Text, ConnectionString.Lambiscadas) == 1);
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}