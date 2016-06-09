function parsearFecha(fecha) {
    var fecha2 = "";
    if (fecha.length == 10) {
        fecha2 = fecha.substring(6, 10) + "-" + fecha.substring(3, 5) + "-" + fecha.substring(0, 2);
    }
    return fecha2;
}

function setearCheckbox(chk) {
    $("input[name='" + chk + "']").val($('#' + chk).prop("checked"));
}

function setearCheckboxes() {
    $.each(
        $("#form").find("input[type='checkbox']"),
        function (i, e) {
            var seleccionado = $(e).prop("checked");
            console.log($(e).attr("id") + " " + seleccionado);
            $("input[name='" + $(e).attr("id") + "']").val(seleccionado);
        }
    );
}

var posteandoFormulario = false;
function postForm(action) {
    $.ajax({
        method: "POST",
        url: "~/Pasos/" + action + "/",
        data: $("#form").serialize(),
        beforeSend: function (xhr) {
            if (posteandoFormulario) {
                console.log("Ya está subiendo el formulario");
                xhr.abort();
                return;
            }
            posteandoFormulario = true;
        },
        success: function (data) {
            if (data == "Fallo") {
                posteandoFormulario = true;
                $("#hdnPopup").val("FinSession");
                $("#contenidoPopup").text("Se le ha vencido la sesión, debe volver a iniciar sesión");
                $("#popup").modal();
            } else {
                posteandoFormulario = false;
            }
        },
        error: function () {

        },
        cache: false
    });
}

function postFormGuardar(action) {
    $.ajax({
        method: "POST",
        url: "~/Pasos/" + action + "/",
        data: $("#form").serialize(),
        beforeSend: function (xhr) {
            if (posteandoFormulario) {
                console.log("Ya está subiendo el formulario");
                xhr.abort();
                return;
            }
            posteandoFormulario = true;
        },
        success: function (data) {
            if (data == "Fallo") {
                posteandoFormulario = true;
                $("#hdnPopup").val("FinSession");
                $("#contenidoPopup").text("Se le ha vencido la sesión, debe volver a iniciar sesión");
                $("#popup").modal();
            } else {
                posteandoFormulario = false;
                $("#hdnPopup").val() == "GuardadoOK"
                $("#contenidoPopup").text("Cambios guardados correctamente.");
                $("#popup").modal();
            }
        },
        error: function () {

        },
        cache: false
    });
}