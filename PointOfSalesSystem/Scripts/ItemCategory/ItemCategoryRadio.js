$(document).ready(function () {
    $("#Add1").hide();

    $(":radio:eq(1)").click(function () {
        $("#Add1").show(1000);

    });

    $(":radio:eq(0)").click(function () {

        $("#Add1").hide(1000);
    });

});
