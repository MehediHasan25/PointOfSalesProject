$(document).ready(function () {
    $("#submit").click(function () {
        getSelectedItem()
    });
});

function getSelectedItem() {
    var item = $("#ItemId").val();

    alert(item);
}