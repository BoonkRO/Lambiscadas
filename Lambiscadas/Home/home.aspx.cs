using Lambiscadas.Clases;
using Lambiscadas.Clases.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lambiscadas.Home
{
    public partial class home : System.Web.UI.Page
    {
        public Usuario loggedUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Utilities.validezUsuario(HttpContext.Current.Request))
            {
                string tokenLoggedUser = Utilities.getParam(HttpContext.Current, "token");
                loggedUser = new Usuario(tokenLoggedUser);
            }
            else
            {
                //Response.Redirect("../CerrarSesion/CerrarSesion.aspx", false);
            }
        }
    }
}