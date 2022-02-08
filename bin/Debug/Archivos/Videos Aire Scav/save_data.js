var id = null;
var clase = null;
var valor = null;
var selector = null;

var clase_cero = null;
var clase_uno = null;


var index_path = "index";
var admin_img_path = "administradorimagen";
var soluciones_path = "soluciones";
var funciones_path = "funciones.html";
var fun_pdf_path = "funcionespdf";
var importacion_path = "importacion";
var flujos_path = "flujos.html";
var catalogos_path = "catalogos.html";
var reportes_path = "reportes.html";




var button = document.querySelector('#acpt_cambios');
var path = window.location.pathname;
var cookies = readCookies();


button.style.display = 'none';

if (path !== null || path !== '' || path !== undefined) {

    if (path.match(admin_img_path) || path.match(index_path) ||  path.match(fun_pdf_path) || path.match(importacion_path)) {
        
        selector = document.querySelectorAll('.contenedor div.row2 .btnadmin');
        clase_cero = "btnadmin_new";
        clase_uno = "btnadmin";
        procesa_path();



    } else if (path.match(soluciones_path) || path.match(funciones_path) || path.match(reportes_path) || path.match(catalogos_path) || path.match(flujos_path)) { 
        
        selector = document.querySelectorAll('.contenedor div div a.btn'); 
        clase_cero = "btn_new"; 
        clase_uno = "btn"; 
        procesa_path();
        
    } else {
        console.log("Path no definido");
    }
}


if (cookies !== '' || cookies !== null || cookies !== undefined) {
    actualizaElementos(cookies);
}




function procesa_path() {

    var auto_generate_id = 0;
    selector.forEach(element => {

        element.id = "idag" + auto_generate_id++;

        if (element.value === null || element.value === '' || element.value === undefined) {
            element.value = 0;
        }

        if (cookies === '' || cookies === null || cookies === undefined) {

            id = element.id;
            clase = element.className;
            valor = element.value;

            saveCookie(id, clase, valor, 2592000, path);
        }

        id = null, clase = null, valor = null;
    });
}


function __aceptar() {
    selector.forEach(element => {
        element.removeEventListener('click', evento);
    });
    button.style.display = 'none';
}


function __click() {
    button.style.display = 'block';
    selector.forEach(element => {
        element.addEventListener('click', evento);
    });

}


function evento() {


    if (window.event.srcElement.value === 1) {        
        
        window.event.srcElement.value = 0;        
        if (window.event.srcElement.className.match("btn_imagen_negro")) {
            window.event.srcElement.className = clase_uno + " btn_imagen_negro";
        } else {
            window.event.srcElement.className = clase_uno;
        }

        id = window.event.srcElement.id;
        clase = window.event.srcElement.className;
        valor = window.event.srcElement.value;

        saveCookie(id, clase, valor, 2592000, path);

    } else {

        window.event.srcElement.value = 1;
        if (window.event.srcElement.className.match("btn_imagen_negro")) {
            window.event.srcElement.className = clase_cero + " btn_imagen_negro";
        } else {
            window.event.srcElement.className = clase_cero;
        }

        id = window.event.srcElement.id;
        clase = window.event.srcElement.className;
        valor = window.event.srcElement.value;

        saveCookie(id, clase, valor, 2592000, path);
    }



    window.event.preventDefault();
}




function readCookies() {
    return document.cookie;
}


function saveCookie(nombre, clase, valor, expire, path) {

    if (clase !== null || clase !== '' || clase !== undefined) {
        document.cookie = nombre + "&clase=" + clase + "; max-age=" + expire + "; path=" + path;
    }

    if (valor !== null || valor !== '' || valor !== undefined) {
        document.cookie = nombre + "&valor=" + valor + "; max-age=" + expire + "; path=" + path;
    }

}


function deleteCookie(nombre, clase, valor, path) {

    if (clase !== null || clase !== '' || clase !== undefined) {
        document.cookie = nombre + "&clase=" + clase + "; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=" + path;
    }

    if (valor !== null || valor !== '' || valor !== undefined) {
        document.cookie = nombre + "&valor=" + valor + "; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=" + path;
    }
}


function actualizaElementos(cookies) {

    var resultado_cookie = cookies.split(";");
    for (var i = 0; i < resultado_cookie.length; i++) {
        var resultado_element = resultado_cookie[i].split("&");

        selector.forEach(element => {
            if (element.id.trim() === resultado_element[0].trim()) {
                if (resultado_element[1].match(clase_cero)) {
                    if (resultado_element[1].match("btn_imagen_negro")) {
                        element.setAttribute("class", clase_cero + " btn_imagen_negro");
                    } else {
                        element.setAttribute("class", clase_cero);
                    }                    
                    element.value = 1;
                }
            }
        });
    }
}