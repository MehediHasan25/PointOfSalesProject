
﻿$(document).ready(function () {

﻿

    $("#BranchId").change(function () {
        var branId = $("#BranchId").val();
        var jsonData = { branchId: branId }
        $.ajax({
            url: "/EmployeeInfo/GetByBranch",
            data: jsonData,
            type: "post",
            //contentType: "application/json",
            success: function (response) {
                var employeeDD = $("#EmployeeInfoId");
                employeeDD.empty();
                var option = "<option value>--Select..</option>";

                $.each(response, function (key, employee) {
                    option += "<option value='" + employee.Id + "'>" + employee.Code + "--" + employee.Name + "</option>";

                });
                employeeDD.append(option);
            },
            error: function (response) { }
        });



    });


    
$("#addButton").click(function () {


        var selectedItem = getSelectedItem();
        CreateRowForPurchaseDetails(selectedItem);

    });


   



});





//function createRowForPurchaseDetails(selectedItem) {
//    index = $("#purchaseTable").children("tr").length;

//    var IndexCell = "<td><input type='hidden' name='PurchaseReceivingDetailses.Index' value='" + index + "'/>" + index + "</td>"
//    var Item = "<td><input type='hidden' name='PurchaseReceivingDetailses[" + index + "].ItemId' value='" + selectedItem.ItemId + "'/>" + selectedItem.ItemName+"</td>"
//    var Quantity = "<td><input type='hidden' name='PurchaseReceivingDetailses[" + index + "].Quantity' value='" + selectedItem.Quantity + "'/>" + selectedItem.Quantity + "</td>"
//    var Price = "<td><input type='hidden' name='PurchaseReceivingDetailses[" + index + "].PurchasePrice' value='" + selectedItem.Price + "'/>" + selectedItem.Price + "</td>"
//    var LiveTotal = "<td><input type='hidden' name='PurchaseReceivingDetailses[" + index + "].PurchaseItemTotalPrice' value='" + selectedItem.LiveTotal + "'/>" + selectedItem.LiveTotal + "</td>"
//    var ActionLink ="<td>Incomplete</td>"

//    var row = "<tr>" + IndexCell + Item + Quantity + Price + LiveTotal + ActionLink + "</tr>";

    
//    $("#purchaseTable").append(row);
//}

//function getSelectedItem() {
//    var ItemId = $("#Item").val();
//    var ItemName = $("#Item option:selected").text();
//    var Quantity = $("#Quantity").val();
//    var Price = $("#PurchasePrice").val();
//    var LiveTotal = $("#PurchasePrice").val() * $("#Quantity").val();

//    var model = {
//        "ItemId": ItemId,
//        "ItemName": ItemName,
//        "Quantity": Quantity,
//        "Price": Price,
//        "LiveTotal": LiveTotal,
//    };
//  return model;
//}