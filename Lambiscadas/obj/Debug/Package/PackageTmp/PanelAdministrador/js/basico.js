$(document).ready(function () {
    $.ajax({
        type: "POST",
        url: "handlerPanelAdministrador.ashx?op=CargarProductos",
        data: {},
        success: function (data) {
            CargarProductos(data);
        },
        error: function () {
            alert("Algo ha salido mal.");
        }
    });
    var image = document.getElementById("uploadFile").addEventListener('change', handleFileSelect, false);
});
var imageBytes;

function ModalNuevoProducto() {
    $("#ModalNuevoProducto").modal();
}

function NuevoProducto() {
    var Nombre = document.getElementById("NombreNuevo").value;
    var Descripcion = document.getElementById("DescripcionNuevo").value;
    var Precio = document.getElementById("PrecioNuevo").value;
    var Stock = document.getElementById("StockNuevo").value;
    

    if (!Nombre || !Descripcion || !Precio || !Stock) {
        alert("Todos los campos tiene que estar rellenados.");
    } else {

        $.ajax({
            type: "POST",
            url: "handlerPanelAdministrador.ashx?op=AñadirNuevoProducto",
            data: { Nombre: Nombre, Descripcion: Descripcion, Precio: Precio, Stock: Stock, Image: imageBytes },
            success: function (data) {
                if (data == "1") {
                    alert("Nuevo producto '" + Nombre + "' añadido.");
                    location.reload();
                } else {
                    alert("ERROR al añadir el nuevo producto '" + Nombre + "'.");
                }
            },
            error: function () {
                alert("Algo ha salido mal.");
            }
        });
    }
}

function handleFileSelect(evt) {
    var f = evt.target.files[0]; // FileList object
    var reader = new FileReader();
    // Closure to capture the file information.
    reader.onload = (function (theFile) {
        return function (e) {
            var binaryData = e.target.result;
            //Converting Binary Data to base 64
            var base64String = window.btoa(binaryData);
            //showing file converted to base64
            imageBytes = base64String;
            
        };
    })(f);
    // Read in the image file as a data URL.
    reader.readAsBinaryString(f);
}


function GuardarValoresProducto(idProducto) {
    var NombreProducto = document.getElementById("NuevoNombreProducto" + idProducto).value;
    var NuevoPrecio = document.getElementById("NuevoPrecioProducto" + idProducto).value;
    var NuevoStock = document.getElementById("NuevoStockProducto" + idProducto).value;

    $.ajax({
        type: "POST",
        url: "handlerPanelAdministrador.ashx?op=GuardarNuevosValores",
        data: { idProducto: idProducto, NuevoNombre: NombreProducto, NuevoPrecio: NuevoPrecio, NuevoStock: NuevoStock },
        success: function (data) {
            if (data == "1") {
                alert("Cambio guardado correctamente.");
                location.reload();
            } else {
                alert("ERROR. No se ha podido guardar el cambio.");
                location.reload();
            }
        },
        error: function () {
            alert("ERROR. No se ha podido guardar el cambio.");
        }
    });
}

function EliminarProducto(idProducto) {
    var NombreProducto = document.getElementById("NuevoNombreProducto" + idProducto).value;

    $.ajax({
        type: "POST",
        url: "handlerPanelAdministrador.ashx?op=EliminarProducto",
        data: { idProducto: idProducto },
        success: function (data) {
            if (data == "1") {
                alert("Producto '" + NombreProducto + "' eliminado correctamente.");
                location.reload();
            } else {
                alert("ERROR. No se ha podido eliminar el producto '" + NombreProducto + "'.");
                location.reload();
            }
        },
        error: function () {
            alert("ERROR. No se ha podido eliminar el producto '" + NombreProducto + "'.");
        }
    });
}

function CargarProductos(data) {
    var jsonParsed = JSON.parse(data);
    var idProducto = "";
    var Nombre = "";
    var Descripcion = "";
    var Precio = "";
    var Stock = "";

    var posi = 0;

    for (var i = 0; i < jsonParsed.length; i++) {
        idProducto = jsonParsed[i].idProducto;
        Nombre = jsonParsed[i].Nombre;
        Descripcion = jsonParsed[i].Descripcion;
        Precio = jsonParsed[i].Precio;
        Stock = jsonParsed[i].Stock;


        var htmlNuevo = "<div class='col-md-4'>" +
            "<h4 class='NombreArticuloLink NombreProducto'>" + Nombre + "</h4 >" +
            "<img alt='Bootstrap Image Preview' class='ImagenProducto' src='../imgs/" + idProducto + ".jpg' id='" + idProducto + "' onclick='verArticulo(" + idProducto + ")'>" +
                "<div class='col-md-12'>" +
                    "<div class='col-md-6' id='divNuevoNombre" + idProducto + "'>" +
                        "<dl>" +
                            "<dt>Nombre:" +
                            "</dt>" +
                            "<dd class='DescProducto'>" +
                                "<input type='text' value='" + Nombre + "' id='NuevoNombreProducto" + idProducto + "' />" +
                            "</dd>" +
                        "</dl>" +
                    "</div>" +
                "</div>" +
                "<div class='col-md-12'>" +
                    "<div class='col-md-4' id='divNuevoPrecio" + idProducto + "'>" +
                        "<dl>" +
                            "<dt>Precio: (€)" +
                            "</dt>" +
                            "<dd class='PrecioProducto'>" +
                                "<input type='text' value='" + Precio + "' id='NuevoPrecioProducto" + idProducto + "' />" +
                            "</dd>" +
                        "</dl>" +
                    "</div>" +
                "</div>" +
                "<div class='col-md-12'>" +
                    "<div class='col-md-6'>" +
                        "<dl>" +
                            "<dt>Stock:" +
                            "</dt>" +
                            "<dd>" +
                                "<input type='number' id='NuevoStockProducto" + idProducto + "' min='0' max='100' value='" + Stock + "' />" +
                            "</dd>" +
                        "</dl>" +
                    "</div>" +
                "</div>" +
                "<div class='col-md-12'>" +
                    "<div class='col-md-6'>" +
                            "<button type='button' class='btn btn-success' onclick='GuardarValoresProducto(" + idProducto + ")'>" +
                        "Guardar" +
                            "</button>" +
                    "</div>" +
                    "<div class='col-md-6'>" +
                        "<button type='button' class='btn btn-danger' onclick='EliminarProducto(" + idProducto + ")'>" +
                            "Eliminar" +
                        "</button>" +
                    "</div>" +
                "</div>" +
        "</div>";


        document.getElementById("contenedorProductoAdmin0").innerHTML += htmlNuevo;
        
    }
}