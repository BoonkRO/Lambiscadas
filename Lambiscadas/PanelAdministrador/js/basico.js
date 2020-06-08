
function GuardarValoresProducto(idProducto) {
    var NombreProducto = document.getElementById("NuevoNombreProducto" + idProducto);
    var PrecioProducto = document.getElementById("NuevoPrecioProducto" + idProducto);
    var StockProducto = document.getElementById("NuevoStockProducto" + idProducto);

    $.ajax({
        type: "POST",
        url: "handlerPanelAdministrador.ashx?op=GuardarNuevosValores",
        data: { idProducto: idProducto, NuevoNombre: NombreProducto, NuevoPrecio: NuevoPrecio, NuevoStock: NuevoStock },
        success: function (data) {
            alert("Cambio guardado correctamente.");
        },
        error: function () {
            alert("ERROR. No se ha podido guardar el cambio.");
        }
    });
}