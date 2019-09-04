
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
        alert("Campo 'email' no puede estar vacío.");
    } else if (password == "") {
        alert("Campo 'password' no puede estar vacío.");
    }

    $.ajax({
        type: "POST",
        url: "handlerLogin.ashx?op=getDatosLogin",
        data: { "Email": email, "Password": password },
        success: function (data) {
            alert(data);
            if (!data) {
                alert("Email o contraseña incorrecto.");
            }
            location.href = "../Home/home.aspx";
        },
        error: function () {
            alert("Algo ha salido mal.");
        }
    });
}