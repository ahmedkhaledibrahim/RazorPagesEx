$('#SubmitEmployeeDetails').submit(function (e) {
    if (!validateForm()) {
        e.preventDefault();
    }
})

function validateForm() {
    var isValid = true;

    // Clear previous validation messages
    $(".text-danger").text("");

    // Validate Name (Required)
    var name = $("#EmployeeName").val().trim();
    if (name === "") {
        isValid = false;
        $("#EmployeeName").next(".text-danger").text("Name is required.");
    }

    // Validate Email (Required and valid email format)
    var email = $("#EmployeeEmail").val().trim();
    if (email === "") {
        isValid = false;
        $("#EmployeeEmail").next(".text-danger").text("Email is required.");
    } else if (!validateEmail(email)) {
        isValid = false;
        $("#EmployeeEmail").next(".text-danger").text("Invalid email format.");
    }

    // Validate Department (Required)
    var department = $("#EmployeeDepartment").val();
    if (department === "") {
        isValid = false;
        $("#EmployeeDepartment").next(".text-danger").text("Department is required.");
    }

    return isValid;
}
