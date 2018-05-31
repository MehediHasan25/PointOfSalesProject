$(document).ready(function () {
    $('#per').hide();

    $("#personal").on('click', function () {
        $('#per').show();
        $('#off').hide();
    });

    $("#official").on('click', function () {

        $("#off").show();
        $("#per").hide();
    });
});




//$(document).ready(function () {


//    $("#BranchId").change(function () {
//        var branId = $("#BranchId").val();
//        var jsonData = { branchId: branId }


//        $.ajax({
//            url: "/EmployeeInfo/GetByBranch",
//            data: jsonData,
//            type: "post",
//            success: function (response) {
//                var employeeinfoDD = $("#EmployeeInfosId");
//                employeeinfoDD.empty();
//                var option = "<option value>Select...</option>";

//                $.each(response, function (key, employeeInfo) {
//                    option += "<option value='" + employeeInfo.Id + "'>" + employeeInfo.Name + "</option>";

//                });

//                employeeinfoDD.append(option);
//            }, 
//            error:function(response)
//        });
//    });

//});