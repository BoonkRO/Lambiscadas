<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Lambiscadas.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Información de contacto</h3>
    <address>
        <abbr title="Direccion"><b>Dirección:</b></abbr>
        Cardenal Rossell, 44<br />
        Islas Baleares, España<br />
        <abbr title="Phone"><b>Teléfono:</b></abbr>
        971265477
    </address>
    <address>
        <strong>Correo:</strong>   <a href="#">lambiscadascoll@gmail.com</a><br />
    </address>
</asp:Content>
