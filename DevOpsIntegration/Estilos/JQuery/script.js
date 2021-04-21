﻿/*Function to sideBar from page VisConfiguration*/
$(function () {
    $('#home').tab('show')
})

$(function () {
    $('#minhaLista a').on('click', function (e) {
        e.preventDefault()
        $(this).tab('show')
    })
})

/*Function to Show a alert message*/
function ShowMessage(message, messagetype) {
    var cssclass;
    switch (messagetype) {
        case 'Sucesso':
            cssclass = 'alert-success'
            break;
        case 'Erro':
            cssclass = 'alert-danger'
            break;
        case 'Alerta':
            cssclass = 'alert-warning'
            break;
        default:
            cssclass = 'alert-info'
    }
    $('#alert_container').append('<div id="alert_div" style="margin: 0 0.5%; -webkit-box-shadow: 3px 4px 6px #999;" class="alert ' + cssclass + ' fade in"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><span>' + message + '</span></div>');

    setTimeout(function () {
        $("#alert_div").fadeTo(4000, 500).slideUp(500, function () {
            $("#alert_div").remove();
        });
    }, 500);//500=0,5 seconds to open
}