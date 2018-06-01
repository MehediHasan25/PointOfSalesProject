$(document).ready(function () {
    $("#addItem").click(function () {
        var selectedItem = getSelectedItem();
        createRowForPurchaseDetails(selectedItem);
    });
});

function createRowForPurchaseDetails(selectedItem) {
    index = $("#ExpenseDetailsTable").children("tr").length;

    var IndexCell = "<td><input type='hidden' name='ExpenseDetailses.Index' value='" + index + "'/>" + index + "</td>";
    var ExpenseItem = "<td><input type='hidden' name='ExpenseDetailses[" + index + "].ExpenseItemId' value='" + selectedItem.ExpenseItemId + "'/>" + selectedItem.ExpenseItemName + "</td>";
    var Quantity = "<td><input type='hidden' name='ExpenseDetailses[" + index + "].Quantity' value='" + selectedItem.Quantity + "'/>" + selectedItem.Quantity + "</td>";
    var Amount = "<td><input type='hidden' name='ExpenseDetailses[" + index + "].Amount' value='" + selectedItem.Amount + "'/>" + selectedItem.Amount + "</td>";
    var LiveTotal = "<td><input type='hidden' name='ExpenseDetailses[" + index + "].ExpenseItemTotalPrice' value='" + selectedItem.LiveTotal + "'/>" + selectedItem.LiveTotal + "</td>";
    var Description = "<td><input type='hidden' name='ExpenseDetailses[" + index + "].Description' value='" + selectedItem.Description + "'/>" + selectedItem.Description + "</td>";
    var ActionLink = "<td>Incomplete</td>";

    var row = "<tr>" + IndexCell + ExpenseItem + Quantity + Amount + LiveTotal + Description + ActionLink + "</tr>";


    $("#ExpenseDetailsTable").append(row);
}

function getSelectedItem() {
    var ExpenseItemId = $("#ExpenseItem").val();
    var ExpenseItemName = $("#ExpenseItem option:selected").text();
    var Quantity = $("#Quantity").val();
    var Amount = $("#Amount").val();
    var LiveTotal = $("#Amount").val() * $("#Quantity").val();
    var Description = $("#Description").val();

    var model = {
        "ExpenseItemId": ExpenseItemId,
        "ExpenseItemName": ExpenseItemName,
        "Quantity": Quantity,
        "Amount": Amount,
        "LiveTotal": LiveTotal,
        "DescriptionS": Description
    };
    return model;
}