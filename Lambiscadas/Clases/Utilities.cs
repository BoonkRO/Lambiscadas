using System;
using System.Collections.Generic;
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
    }
}