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
				<div class="col-md-12">
					<h3 class="tituloSeccion">
						ARTÍCULOS EN PROMOCIÓN
					</h3>
					<div class="row">
						<div class="col-md-3">
							<h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoDeadPool400.jpg" id="1" onclick="verArticulo(this.id)">
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
							<h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoBareBears.jpg" id="2" onclick="verArticulo(this.id)">
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
							<h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoJerry.jpeg" id="3" onclick="verArticulo(this.id)">
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
							<h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoSquirtle.jpg" id="4" onclick="verArticulo(this.id)">
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
			<div class="row">
				<div class="col-md-12">
					<h3 class="tituloSeccion">
						RECOMENDACIONES
					</h3>
					<div class="row">
						<div class="col-md-3">
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoTenShinHan.jpg" id="5" onclick="verArticulo(this.id)">
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
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoMrBurns.jpg" id="6" onclick="verArticulo(this.id)">
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
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoCapitanAmerica.jpg" id="7" onclick="verArticulo(this.id)"> 
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
							 <h4 class="NombreArticuloLink">Funko Pop DeadPool</h4><img alt="Bootstrap Image Preview" src="../imgs/funkoKaiBubbles.jpg" id="8" onclick="verArticulo(this.id)">
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
