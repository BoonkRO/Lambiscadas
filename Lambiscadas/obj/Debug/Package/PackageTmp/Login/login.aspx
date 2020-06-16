<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Lambiscadas.Login.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Log In Lambiscadas</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet">
    <link rel='stylesheet' href='css/basico.css' type='text/css' />
    <link rel='stylesheet' href='../css/basico.css' type='text/css' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12">
        <div class="col-md-4">
        </div>
        <div class="col-md-4 divLogin">
            <h2>Login Lambiscadas</h2>
            <span>Email:</span>
            <input type="text" id="email" />
            <br />
            <span>Contraseña:</span>
            <input type="password" id="password" />
            <br />
            <br />
            <input type="button" value="Iniciar Sesión" class="btn btn-primary" onclick="getDatosLogIn()" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <a href="#">Registrarme</a>
        </div>
        <div class="col-md-4">
        </div>
    </div>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="js/basico.js" type="text/javascript"></script>
</asp:Content>
