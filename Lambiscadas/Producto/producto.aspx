<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="producto.aspx.cs" Inherits="Lambiscadas.Producto.producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Producto</title>
    <link rel='stylesheet' href='css/basico.css' type='text/css' />
    <link rel='stylesheet' href='../css/basico.css' type='text/css' />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
	<div class="row">


		<div class="col-md-12">
			<div class="row divDatosProducto">
				<div class="col-md-6 divImagenProducto">
					<img alt="Bootstrap Image Preview" src="../imgs/Producto/funkoCapitanAmerica.jpg">
				</div>
				<div class="col-md-6">
					<dl>
						<dt>
							Description lists
						</dt>
						<dd>
							A description list is perfect for defining terms.
						</dd>
						<dt>
							Euismod
						</dt>
						<dd>
							Vestibulum id ligula porta felis euismod semper eget lacinia odio sem nec elit.
						</dd>
						<dd>
							Donec id elit non mi porta gravida at eget metus.
						</dd>
						<dt>
							Malesuada porta
						</dt>
						<dd>
							Etiam porta sem malesuada magna mollis euismod.
						</dd>
						<dt>
							Felis euismod semper eget lacinia
						</dt>
						<dd>
							Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.
						</dd>
					</dl>
					<dl>
						<dt>
							Description lists
						</dt>
						<dd>
							A description list is perfect for defining terms.
						</dd>
						<dt>
							Euismod
						</dt>
						<dd>
							Vestibulum id ligula porta felis euismod semper eget lacinia odio sem nec elit.
						</dd>
						<dd>
							Donec id elit non mi porta gravida at eget metus.
						</dd>
						<dt>
							Malesuada porta
						</dt>
						<dd>
							Etiam porta sem malesuada magna mollis euismod.
						</dd>
						<dt>
							Felis euismod semper eget lacinia
						</dt>
						<dd>
							Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.
						</dd>
					</dl> 
					<button type="button" class="btn btn-success btn-md">
						Añadir al carrito
					</button>
				</div>
			</div>
			<div class="row">
				<div class="col-md-12">
					<h3 class="tituloSeccion">
						RECOMENDACIONES
					</h3>
					<div class="row">
						<div class="col-md-3">
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoSquirtle.jpg" id="5" onclick="verArticulo(this.id)">
                            <dl>
								<dt>
									Descripción
								</dt>
								<dd>
									Funko Pop DeadPool
								</dd>
							</dl> 
							<button type="button" class="btn btn-success btn-md">
								Añadir al Carrito
							</button>
						</div>
						<div class="col-md-3">
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoKaiBubbles.jpg" id="6" onclick="verArticulo(this.id)">
                            <dl>
								<dt>
									Descripción
								</dt>
								<dd>
									Funko Pop DeadPool
								</dd>
							</dl> 
							<button type="button" class="btn btn-success">
								Añadir al Carrito
							</button>
						</div>
						<div class="col-md-3">
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoMrBurns.jpg" id="7" onclick="verArticulo(this.id)"> 
                            <dl>
								<dt>
									Descripción
								</dt>
								<dd>
									Funko Pop DeadPool
								</dd>
							</dl> 
							<button type="button" class="btn btn-success">
								Añadir al Carrito
							</button>
						</div>
						<div class="col-md-3">
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoJerry.jpeg" id="1" onclick="verArticulo(this.id)">
                            <dl>
								<dt>
									Descripción
								</dt>
								<dd>
									Funko Pop DeadPool
								</dd>
							</dl> 
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
