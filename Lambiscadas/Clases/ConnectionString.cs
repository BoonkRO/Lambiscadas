using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Lambiscadas.Clases
{
    public class ConnectionString
    {
        public static string Lambiscadas = WebConfigurationManager.AppSettings["StringConexion"];
    }
}