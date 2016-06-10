// JavaScript Document

function nuevoAjax() {
    var xmlhttp = false;
    try {
        xmlhttp = new ActiveXObject("Msxml2.XMLHTTP");
    } catch (e) {
        try {
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        } catch (E) {
            xmlhttp = false;
        }
    }

    if (!xmlhttp && typeof XMLHttpRequest != 'undefined') {
        xmlhttp = new XMLHttpRequest();
    }

    return xmlhttp;
}

function goUrl(url) {
    location = url;
}

function goUrl(url, parametros) {
    var cont = document.getElementById('contenedorCarro');
    ajax = nuevoAjax();
    ajax.open('POST', url, true);
    cont.innerHTML = '<img src="loading/Loading.gif" align="middle" />';
    ajax.onreadystatechange = function () {
        if (ajax.readyState == 4) {
            cont.innerHTML = ajax.responseText;
        }
    }
    ajax.setRequestHeader("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
    ajax.send(parametros);
}

//Especifica el ID de la etiqueta del div que llamaria para ajax
function goUrlA(idcont, url, parametros) {
    var cont = document.getElementById(idcont);
    ajax = nuevoAjax();
    ajax.open('POST', url, true);
    cont.innerHTML = '<img src="loading/Loading.gif" align="middle" />';
    ajax.onreadystatechange = function () {
        if (ajax.readyState == 4) {
            cont.innerHTML = ajax.responseText;
        }
    }
    ajax.setRequestHeader("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
    ajax.send(parametros);
}


function 



