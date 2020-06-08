<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Lambiscadas.PanelAdminstrador.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Panel del Administrador</title>
    <link rel='stylesheet' href='css/basico.css' type='text/css' />
    <link rel='stylesheet' href='../css/basico.css' type='text/css' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h4 class="NombreArticuloLink NombreProducto">Funko Pop DeadPool</h4>
                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/1.jpg" id="1" onclick="verArticulo(this.id)">
                <div class="col-md-12">
                    <div class="col-md-6" id="divNuevoNombre">
                        <dl>
                            <dt>Nombre:
                            </dt>
                            <dd class="DescProducto">
                                <input type="text" value="Funko Pop DeadPool" id="NuevoNombreProducto" />
                            </dd>
                        </dl>
                    </div>
                </div>
                <div class="col-md-12">
                    <div class="col-md-4" id="divNuevoPrecio">
                        <dl>
                            <dt>Precio: (€)
                            </dt>
                            <dd class="PrecioProducto">
                                <input type="text" value="1111" id="NuevoPrecioProducto" />
                            </dd>
                        </dl>
                    </div>
                </div>
                <div class="col-md-12">
                    <div class="col-md-6">
                        <dl>
                            <dt>Stock:
                            </dt>
                            <dd>
                                <input type="number" id="NuevoStockProducto" min="0" max="100" value="" />
                            </dd>
                        </dl>
                    </div>
                    <div class="col-md-6">
                        <button type="button" class="btn btn-success" onclick="GuardarValoresProducto(1)">
                            Guardar
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
