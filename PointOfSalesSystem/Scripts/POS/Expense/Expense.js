$(document).ready(function () {
var index = 0;
    $("#addButton").click(function () {
        
    var enrollmentDetail = getEnrollmentDetail();
    var indexCell = "<td style='display:none' ><input type='hidden' name='expenseDetailses.Index' value='" + index + "'></td>";
        var courseNameCell = "<td> <input type='hidden' name='ExpenseDetailses[" + index + "].CourseId' value='" + enrollmentDetail.CourseId + "'>   " + enrollmentDetail.CourseName + "</td>";
        var descriptionCell = "<td> <input type='hidden' name='ExpenseDetailses[" + index + "].Description' value='" + enrollmentDetail.Description + "'>" + enrollmentDetail.Description + "</td>";
        var priceCell = "<td> <input type='hidden' name='ExpenseDetailses[" + index + "].Price' value='" + enrollmentDetail.Price + "'>" + enrollmentDetail.Price + "</td>";

    var tbody = $("#tbenroll");

    var tr = "<tr>" + indexCell + courseNameCell + descriptionCell + priceCell + "</tr>";
    tbody.append(tr);

    ++index;


});
});

function getEnrollmentDetail() {
    
    var expenseItemId = $("#ExpenseItemId").val();
    var expenseItemName = $("#ExpenseItemId option:selected").text();
    var quantity = $("Quantity")
    var description = $("#Description").val();
    var amount = $("#Amount").val();

    var expenseDetails = { : expenseItemId, CourseName: expenseItemName, Description: description, Amount: amount };
    alert(expenseItemId);
    return enrollmentDetails;
}