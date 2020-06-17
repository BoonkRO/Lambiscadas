
function mostrarContraseña() {
    if ($('.showPass').is(':checked')) {
        $('.showPassword').attr("type", "text");
    } else {
        $('.showPassword').attr("type", "password");
    }
}

function getDatosLogIn() {
    var email = $("#email").val();
    var password = $("#password").val();

    if (email == "") {
        return alert("Campo 'email' no puede estar vacío.");
    } else if (password == "") {
        return alert("Campo 'password' no puede estar vacío.");
    }

    $.ajax({
        type: "POST",
        url: "handlerLogin.ashx?op=getDatosLogin",
        data: { "Email": email, "Password": password },
        success: function (data) {
            if (data == "-1") {
                alert("Email o contraseña incorrecto.");
            } else if (data == "1") {
                location.href = "../Home/home.aspx";
            } else {
                alert("Ups...");
                location.reload();
            }
        },
        error: function () {
            alert("Algo ha salido mal.");
        }
    });
}