//function EmployeeValidation() {
//    const results = [];
//    let nationalIdentityNumberAlreadyExists;
//    let phoneNumberAlreadyExists;

//    if (!Employee.NationalIdentityNumber) {
//        results.push("Please enter your National Identity Number.");
//    } else {
//        // Simulate checking if the national identity number already exists in the database
//        nationalIdentityNumberAlreadyExists = checkNationalIdentityNumber(Employee.NationalIdentityNumber);
//        if (nationalIdentityNumberAlreadyExists) {
//            results.push("There already is an account with this national identity number.");
//        }
//    }

//    if (!Employee.FirstName) {
//        results.push("Please enter your first name.");
//    }

//    if (!Employee.LastName) {
//        results.push("Please enter your last name.");
//    }

//    if (!Employee.PhoneNumber) {
//        results.push("Please enter your phone number.");
//    } else {
//        // Simulate checking if the phone number already exists in the database
//        phoneNumberAlreadyExists = checkPhoneNumber(Employee.PhoneNumber);
//        if (phoneNumberAlreadyExists) {
//            results.push("There already is an account with this phone number.");
//        }
//    }
//    if (!Employee.Department) {
//        results.push("Please enter your Department.");
//    }
//    if (!Employee.ManagerName) {
//        results.push("Please enter your Manager Name.");
//    }
//    if (!Employee.JobTitle) {
//        results.push("Please enter your Job Title.");
//    }
//    if (!Employee.CurrentDate) {
//        results.push("Please enter your CurrentDate.");
//    }
//    const currentDate = new Date();
//    if (Employee.CurrentDate > currentDate) {
//        results.push("Please enter a valid CurrentDate.");
//    }
//    var emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
//    var results = [];

//    if (!emailAddress || email.trim() === "")
//        results.push("Please enter an email address.");

//    if (!password || password.trim() === "")
//        results.push("Please enter a password.");

//    if (!confirmPassword || confirmPassword.trim() === "")
//        results.push("Please confirm your password.");

//    if (password && confirmPassword && password !== confirmPassword)
//        results.push("The passwords you entered do not match.");

//    if (!emailRegex.test(emailAddress))
//        results.push("Invalid Email Address!");
//    else {
//        if (accountToBeCrossedCheckedWith.EmailAddress === emailAddress)
//            results.push("Email Address already exists.");
//    }

//    // If there are validation results, handle them accordingly (e.g., display an alert)
//    if (results.length > 0) {
//        var errorMessage = results.join('\n');
//        alert(errorMessage);
//        // Optionally prevent further actions (form submission, etc.)
//        return false;
//    }

//    // Continue with the logic when there are no validation errors
//    return results;
//}

//// Simulated functions to check if the values already exist in the database
//function checkNationalIdentityNumber(nationalIdentityNumber) {
//    // Implement logic to check if the national identity number already exists
//    // in the database or any other data source
//    return false; // Replace with actual logic
//}

//function checkPhoneNumber(phoneNumber) {
//    // Implement logic to check if the phone number already exists
//    // in the database or any other data source
//    return false; // Replace with actual logic
//}
