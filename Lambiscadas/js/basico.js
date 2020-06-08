$(document).ready(function () {
    if (getCookie("token")) {
        document.getElementById("divPerfilUsuario").style.visibility = "hidden";
        document.getElementById("BotonCerrarSesion").style.visibility = "visible";
        document.getElementById("divCarritoPrincipal").style.visibility = "visible";
        document.getElementById("botonAccesoPanelAdmin").style.visibility = "visible";
    } else {
        document.getElementById("divPerfilUsuario").style.visibility = "visible";
        document.getElementById("BotonCerrarSesion").style.visibility = "hidden";
        document.getElementById("divCarritoPrincipal").style.visibility = "hidden";
        document.getElementById("botonAccesoPanelAdmin").style.visibility = "hidden";
    }
});


function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function verArticulo(idProducto) {
    location.href = "../Producto/producto.aspx?idProducto=" + idProducto;
}