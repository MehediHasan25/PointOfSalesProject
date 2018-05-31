$(document).ready(function () {
    $('#per').hide();

    $("#personal").on('click', function () {
        $('#per').show();
        $('#off'). hide();
    });

    $("#official").on('click', function () {

        $("#off"). show();
        $("#per"). hide();
    });
    
});