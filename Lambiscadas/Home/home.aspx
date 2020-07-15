<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Lambiscadas.Home.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home</title>
    <link rel='stylesheet' href='css/basico.css' type='text/css' />
    <link rel='stylesheet' href='../css/basico.css' type='text/css' />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">

                        <img alt="Bootstrap Image Preview" src="../imgs/headerHome.jpg">
                    </div>
                </div>
                <div class="row">
                    <div >
                        <h3 class="tituloSeccion">ARTÍCULOS EN PROMOCIÓN
                        </h3>
                        <div class="row containerItems">
                            <div class="col-md-4 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Pop DeadPool</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/1.jpg" id="1" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Pop DeadPool
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">15.95€
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success">
                                    Añadir al Carrito
                                </button>
                            </div>
                            <div class="col-md-4 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Pop Bare Bears</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/2.jpg" id="2" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Pop Bare Bears
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">15.99 €
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success">
                                    Añadir al Carrito
                                </button>
                            </div>
                            <div class="col-md-4 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Godzilla</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/3.jpg" id="3" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Godzilla
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">12.55 €
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success">
                                    Añadir al Carrito
                                </button>
                            </div>
                            <div class="col-md-4 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Pop Kai Bubbles</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/4.jpg" id="4" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Pop Kai Bubbles
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">9.25 €
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success">
                                    Añadir al Carrito
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <h3 class="tituloSeccion">RECOMENDACIONES
                        </h3>
                        <div class="row">
                            <div class="col-md-3 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Pop Squirtle</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/5.jpg" id="5" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Pop Squirtle
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">
                                                14.95 €
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success btn-md">
                                    Añadir al Carrito
                                </button>
                            </div>
                            <div class="col-md-3 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Pop Ten Shin Han</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/6.jpg" id="6" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Pop Ten Shin Han
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">
                                                11.99 €
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success">
                                    Añadir al Carrito
                                </button>
                            </div>
                            <div class="col-md-3 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Pop Mr Burns</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/1003.jpg" id="1003" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Pop Mr Burns
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">
                                                12.75 €
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success">
                                    Añadir al Carrito
                                </button>
                            </div>
                            <div class="col-md-3 boxItem">
                                <h4 class="NombreArticuloLink NombreProducto">Funko Pop Capitan America</h4>
                                <img alt="Bootstrap Image Preview" class="ImagenProducto" src="../imgs/1004.jpg" id="1004" onclick="verArticulo(this.id)">
                                <div class="col-md-12">
                                    <div class="col-md-8">
                                        <dl>
                                            <dt>Descripción
                                            </dt>
                                            <dd class="DescProducto">Funko Pop Capitan America
                                            </dd>
                                        </dl>
                                    </div>
                                    <div class="col-md-4">
                                        <dl>
                                            <dt>Precio
                                            </dt>
                                            <dd class="PrecioProducto">15.95€
                                            </dd>
                                        </dl>
                                    </div>
                                </div>
                                <button type="button" class="btn btn-success">
                                    Añadir al Carrito
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="js/basico.js" type="text/javascript"></script>
</asp:Content>
