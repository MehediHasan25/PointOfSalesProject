$(document).ready(function () {
    $("#addItem").click(function () {
        var selectedItem = getSelectedItem();
        createRowForPurchaseDetails(selectedItem);
    });
});

function createRowForPurchaseDetails(selectedItem) {
    index = $("#SalesDetailsTable").children("tr").length;

    var IndexCell = "<td><input type='hidden' name='SalesDetailses.Index' value='" + index + "'/>" + index + "</td>";
    var Item = "<td><input type='hidden' name='SalesDetailses[" + index + "].ItemId' value='" + selectedItem.ItemId + "'/>" + selectedItem.ItemName + "</td>";
    var Quantity = "<td><input type='hidden' name='SalesDetailses[" + index + "].Quantity' value='" + selectedItem.Quantity + "'/>" + selectedItem.Quantity + "</td>";
    var Price = "<td><input type='hidden' name='SalesDetailses[" + index + "].SalesPrice' value='" + selectedItem.Price + "'/>" + selectedItem.Price + "</td>";
    var LiveTotal = "<td><input type='hidden' name='SalesDetailses[" + index + "].SalesItemTotalPrice' value='" + selectedItem.LiveTotal + "'/>" + selectedItem.LiveTotal + "</td>";
    var ActionLink = "<td>Incomplete</td>";

    var row = "<tr>" + IndexCell + Item + Quantity + Price + LiveTotal + ActionLink + "</tr>";


    $("#SalesDetailsTable").append(row);
}

function getSelectedItem() {
    var ItemId = $("#Item").val();
    var ItemName = $("#Item option:selected").text();
    var Quantity = $("#Quantity").val();
    var Price = $("#SalesPrice").val();
    var LiveTotal = $("#SalesPrice").val() * $("#Quantity").val();

    var model = {
        "ItemId": ItemId,
        "ItemName": ItemName,
        "Quantity": Quantity,
        "Price": Price,
        "LiveTotal": LiveTotal
    };
    return model;
}