$(function () {
    actualizarGrilla();

    $("#btnguardar").click(function () {
        if (validar() === true) {
            alert("Guardado");
        } else {
            alert("Se deben completar todos los campos");
        }
    });

    $("#btncancelar").click(function () {
        alert("Cancelado");
    });

    $("#btneliminar").click(function () {

        alert("Eliminado");
    });

    //Establece el boton a Nuevo.
    $("#guardar").val("Nuevo");


});

function validar() {

    var validacion = true;

    if ($('#Nombre').val() == "") {
        validacion = true;
    }

    if ($('#Description').val() == "") {
        validacion = false;
    }

    if ($('#Precio').val() < 0) {
        validacion = false;
    }

    if ($('#Stock').val() < 0) {
        validacion = false;
    }

    return validacion;
}

function actualizarGrilla() {
    var data = ajaxGET();
    construirGrilla(data);
}

function ajaxGET() {
    var result;

    $.ajax({
        url: 'https://localhost:44343/api/productos',
        type: 'GET',
        async: false
    }).done(function (data) {
        result = data;
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });
    return result;
}

function construirGrilla(data) {
    var grd = $('#gvProductos');
    grd.html("");
    var tbl = $('<table border=1></table>');


    var header = $('<tr></tr>');
    header.append('<td>Id</td>');
    header.append('<td>Nombre</td>');
    header.append('<td>Descripcion</td>');
    header.append('<td>Precio</td>');
    header.append('<td>Stock</td>');

    tbl.append(header);


    for (d in data) {
        var row = $('<tr class="jqClickeable"></tr>');
        row.append('<td>' + data[d].Id + '</td>');
        row.append('<td>' + data[d].Nombre + '</td>');
        row.append('<td>' + data[d].Descripcion + '</td>');
        row.append('<td>' + data[d].Precio + '</td>');
        row.append('<td>' + data[d].Stock + '</td>');

        tbl.append(row);
    }

    grd.append(tbl);
    $('.jqClickeable').click(function () { mostrarElemento($(this)); });

}

function mostrarElemento(elem) {
    $('#id').val(elem.children().eq(0).text());
    $('#nombre').val(elem.children().eq(1).text());
    $('#Descripcion').val(elem.children().eq(2).text());
    $('#Precio').val(elem.children().eq(3).text());
    $('#Stock').val(elem.children().eq(4).text());

    $('#btnguardar').val("Modificar");
}
