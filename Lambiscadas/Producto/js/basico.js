$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "../Home/handlerHome.ashx?op=getProducts",
        dataType: "json",
        success: function (data) {
            BoxProducto(data);
        },
        error: function () {
            alert("No se han podido cargar los productos.");
        }
    });


});




function BoxProducto(data) {

    var NombreProducto = document.getElementsByClassName("NombreProducto");
    var DescripcionProducto = document.getElementsByClassName("DescProducto");
    var PrecioProducto = document.getElementsByClassName("PrecioProducto");
    var ImagenProducto = document.getElementsByClassName("ImagenProducto");
    for (var i = 0; i < data.length; i++) {
        data[i].Orden = Math.floor(Math.random() * 20);
    }

    data = data.sort((a, b) => (a.Orden > b.Orden) ? 1 : ((b.Orden > a.Orden) ? -1 : 0));

    for (let i = 0; i < data.length; i++) {
        NombreProducto[i].innerHTML = data[i].Nombre;
        DescripcionProducto[i].innerHTML = data[i].Descripcion;;
        PrecioProducto[i].innerHTML = data[i].Precio + " €";
        ImagenProducto[i].src = "../imgs/" + data[i].idProducto + ".jpg";
        ImagenProducto[i].id = data[i].idProducto;

    }

}

