


$(document).ready(function () {
    $(":radio:eq(0)").click(function () {
        alert("The paragraph was clicked.");
        //$("#Root").show(1000);
    });

    $(":radio:eq(1)").click(function () {
        $("#cathide").hide(1000);
    });

});