/*Function to sideBar from page VisConfiguration*/
$(function () {
    $('#home').tab('show')
})

$(function () {
    $('#minhaLista a').on('click', function (e) {
        e.preventDefault()
        $(this).tab('show')
    })
})