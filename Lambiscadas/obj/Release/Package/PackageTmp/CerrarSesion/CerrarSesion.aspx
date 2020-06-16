<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CerrarSesion.aspx.cs" Inherits="Lambiscadas.CerrarSesion.CerrarSesion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                string url = "~/Home/home.aspx";
                /* Eliminamos la cookie con el id del usuario */
                if (Request.Cookies["token"] != null)
                {
                    string token = Request.Cookies["token"].Value;
                    HttpCookie myCookie = new HttpCookie("token");

#if !DEBUG
                    myCookie.HttpOnly = true;
                    myCookie.Secure = true;
#endif

                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }
            /* cerramos sesión */
            FormsAuthentication.SignOut();
            /* y redirigimos */
            Response.Redirect(url, false);
             %>
        </div>
    </form>
</body>
</html>