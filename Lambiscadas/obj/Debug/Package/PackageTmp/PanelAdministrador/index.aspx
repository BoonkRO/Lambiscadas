<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Lambiscadas.PanelAdminstrador.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Panel del Administrador</title>
    <link rel='stylesheet' href='css/basico.css' type='text/css' />
    <link rel='stylesheet' href='../css/basico.css' type='text/css' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <br />
        <div class="col-md-12" id="divBotonAgregarProducto">
            <button type="button" class="btn btn-primary" onclick="ModalNuevoProducto()">
                Nuevo Producto
            </button>
        </div>
    </div>

    <div class="container-fluid" id="contenedor4Productos">
        <div class="row" id="contenedorProductoAdmin0">
            <%--            <div class="col-md-4">
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
                </div>
                <div class="col-md-12">
                    <div class="col-md-6">
                        <button type="button" class="btn btn-success" onclick="GuardarValoresProducto(1)">
                            Guardar
                        </button>
                    </div>
                    <div class="col-md-6">
                        <button type="button" class="btn btn-danger" onclick="EliminarProducto(1)">
                            Eliminar
                        </button>
                    </div>
                </div>
            </div>--%>
        </div>
    </div>

    <div class="modal" id="ModalNuevoProducto">
        <div class="modal-dialog">
            <div class="modal-content">

                <div class="modal-header">
                    <h4 class="modal-title">Nuevo Producto</h4>
                </div>

                <div class="modal-body">
                    <div class="col-md-12">
                        <div class="col-md-6" id="divNuevoNombre">
                            <dl>
                                <dt>Nombre:
                                </dt>
                                <dd class="DescProducto">
                                    <input type="text" id="NombreNuevo" />
                                </dd>
                            </dl>
                        </div>
                    </div>

                    <div class="col-md-12">
                        <div class="col-md-6" id="divNuevoDescripcion">
                            <dl>
                                <dt>Descripción:
                                </dt>
                                <dd class="DescProducto">
                                    <input type="text" id="DescripcionNuevo" />
                                </dd>
                            </dl>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="col-md-6" id="divNuevoPrecio">
                            <dl>
                                <dt>Precio: (€)
                                </dt>
                                <dd class="PrecioProducto">
                                    <input type="text" id="PrecioNuevo" />
                                </dd>
                            </dl>
                        </div>
                    
                        <div class="col-md-6">
                            <dl>
                                <dt>Stock:
                                </dt>
                                <dd>
                                    <input type="number" id="StockNuevo" min="0" max="100" value="" />
                                </dd>
                            </dl>
                        </div>
                    </div>
                    <div class="col-md-12" id="divSubirFoto">
                        <input type="file" id="uploadFile">
                    </div>
                </div>

                <div class="footer">
                    <button type="button" class="btn btn-primary" id="BotonAnadir" onclick="NuevoProducto()">Añadir</button>
                    <button type="button" class="btn btn-danger" id="BotonCerrar" data-dismiss="modal">Cancelar</button>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="js/basico.js" type="text/javascript"></script>
</asp:Content>
