$(document).ready(function () {
    $("#addItem").click(function () {
        var selectedItem = getSelectedItem();
        createRowForPurchaseDetails(selectedItem);
    });
});

function createRowForPurchaseDetails(selectedItem) {
    index = $("#purchaseDetailsTable").children("tr").length;

    var IndexCell = "<td><input type='hidden' name='model.PurchaseReceivingDetailses.Index' value='" + index + "'/>" + index + "</td>"
    var Item = "<td><input type='hidden' name='model.PurchaseReceivingDetailses.[" + index + "].ItemId' value='" + selectedItem.ItemName + "'/>" + selectedItem.ItemName+"</td>"
    var Quantity = "<td><input type='hidden' name='model.PurchaseReceivingDetailses.[" + index + "].Quantity' value='" + selectedItem.Quantity + "'/>" + selectedItem.Quantity + "</td>"
    var Price = "<td><input type='hidden' name='model.PurchaseReceivingDetailses.[" + index + "].PurchasePrice' value='" + selectedItem.Price + "'/>" + selectedItem.Price + "</td>"
    var LiveTotal = "<td><input type='hidden' name='model.PurchaseReceivingDetailses.[" + index + "].PurchaseItemTotalPrice' value='" + selectedItem.LiveTotal + "'/>" + selectedItem.LiveTotal + "</td>"
    var ActionLink ="<td>Incomplete</td>"

    var row = "<tr>" + IndexCell + Item + Quantity + Price + LiveTotal + ActionLink + "</tr>";


    $("#purchaseDetailsTable").append(row);
}

function getSelectedItem() {
    var itemId = $("#ItemId").val();
    var ItemName = $("#ItemId option:selected").text();
    var Quantity = $("#Quantity").val();
    var Price = $("#PurchasePrice").val();
    var LiveTotal = $("#PurchasePrice").val() * $("#Quantity").val();

    var model = {
        "itemId": itemId,
        "ItemName": ItemName,
        "Quantity": Quantity,
        "Price": Price,
        "LiveTotal": LiveTotal,
    };
    return model;
}