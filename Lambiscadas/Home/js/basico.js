$(document).ready(function () {
    //$.ajax({
    //    type: "GET",
    //    url: "handlerHome.ashx?op=getProducts",
    //    dataType: "json",
    //    success: function (data) {
    //        BoxProducto();
    //    },
    //    error: function () {
    //        alert("Algo ha salido mal.");
    //    }
    //});
});




function BoxProducto() {
    var bucle = 4;
    var divRecomendados = document.getElementById("contentRecomendados");

    var ruta = "../imgs/funkoDeadPool400.jpg";

    for (let i = 0; i < bucle; i++) {
        var createBoxProducto = document.createElement("div");
        createBoxProducto.setAttribute("class", "boxProducto");

        divRecomendados.appendChild(createBoxProducto);

        var createDivFoto = document.createElement("div");
        createDivFoto.setAttribute("class", "fotoProducto");
        var img = document.createElement("img");
        img.setAttribute("src", ruta);
        createDivFoto.appendChild(img);

        document.getElementsByClassName("boxProducto")[i].appendChild(createDivFoto);

        var createDivDesc = document.createElement("div");
        createDivDesc.setAttribute("class", "descripcionProducto");

        var spanDesc = document.createElement("span");
        spanDesc.setAttribute("class", "divDesc");
        createDivDesc.appendChild(spanDesc);

        document.getElementsByClassName("boxProducto")[i].appendChild(createDivDesc);
        document.getElementsByClassName("divDesc")[i].innerHTML = "descipcion del producto";

        var createDivPrecio = document.createElement("div");
        createDivPrecio.setAttribute("class", "precioProducto");

        var spanPrecio = document.createElement("span");
        spanPrecio.setAttribute("class", "divPrecio");
        createDivPrecio.appendChild(spanPrecio);

        document.getElementsByClassName("boxProducto")[i].appendChild(createDivPrecio);
        document.getElementsByClassName("divPrecio")[i].innerHTML = "15.50€";

        var botonCarro = document.createElement("input");
        botonCarro.setAttribute("type", "button");
        botonCarro.setAttribute("class", "botonCarro");
        botonCarro.setAttribute("value", "Añadir al Carro");
        botonCarro.setAttribute("id", "1" /*idProducto*/);

        document.getElementsByClassName("boxProducto")[i].appendChild(botonCarro);

    }

}

function verArticulo(idProducto) {
    location.href = "../Producto/producto.aspx?idProducto=" + idProducto;
}