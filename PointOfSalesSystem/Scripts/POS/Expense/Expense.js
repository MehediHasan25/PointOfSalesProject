$(document).ready(function () {
var index = 0;
    $("#addButton").click(function () {
        alert("Refat bhai kaj koren");
    var enrollmentDetail = getEnrollmentDetail();
    var indexCell = "<td style='display:none' ><input type='hidden' name='EnrollmentDetailses.Index' value='" + index + "'></td>";
    var courseNameCell = "<td> <input type='hidden' name='EnrollmentDetailses[" + index + "].CourseId' value='" + enrollmentDetail.CourseId + "'>   " + enrollmentDetail.CourseName + "</td>";
    var descriptionCell = "<td> <input type='hidden' name='EnrollmentDetailses[" + index + "].Description' value='" + enrollmentDetail.Description + "'>" + enrollmentDetail.Description + "</td>";
    var priceCell = "<td> <input type='hidden' name='EnrollmentDetailses[" + index + "].Price' value='" + enrollmentDetail.Price + "'>" + enrollmentDetail.Price + "</td>";

    var tbody = $("#tbenroll");

    var tr = "<tr>" + indexCell + courseNameCell + descriptionCell + priceCell + "</tr>";
    tbody.append(tr);

    ++index;


});
});

function getEnrollmentDetail() {
    var courseId = $("#ExpenseItemId").val();
    var courseName = $("#ExpenseItemId option:selected").text();
    var description = $("#Description").val();
    var price = $("#Price").val();

var enrollmentDetails = { CourseId: courseId, CourseName: courseName, Description: description, Price: price };
    alert(courseId);
    return enrollmentDetails;
}