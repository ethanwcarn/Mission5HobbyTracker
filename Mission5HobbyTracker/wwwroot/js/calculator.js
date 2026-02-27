// calculator.js — jQuery-powered Tutoring Calculator for Cougs Clothes
// IS 413 Mission 5 — Uses jQuery selectors and event handling

// Wait for the DOM to be fully loaded before attaching event handlers
$(document).ready(function () {
    // Define the fixed hourly tutoring rate as a constant
    const HOURLY_RATE = 25.00;

    // Attach a click event handler to the Calculate button using jQuery selector
    $('#calculateBtn').on('click', function () {
        // Select the hours input element using jQuery
        const hoursInput = $('#hours');
        // Parse the entered value as a floating-point number
        const hoursValue = parseFloat(hoursInput.val());
        // Select the error message div using jQuery
        const errorDiv = $('#hoursError');

        // Hide any previously displayed error message and clear its text
        errorDiv.hide().text('');

        // Validate that the input is a positive number (not NaN, not zero, not negative)
        if (isNaN(hoursValue) || hoursValue <= 0) {
            // Display an error message if the input is invalid
            errorDiv.text('Please enter a valid positive number of hours.').show();
            // Clear the total output field since the input is invalid
            $('#total').val('');
            // Stop execution — do not calculate with invalid input
            return;
        }

        // Calculate the total cost by multiplying hours by the hourly rate
        const total = hoursValue * HOURLY_RATE;
        // Display the formatted total as currency (e.g., "$125.00") in the total field using jQuery
        $('#total').val('$' + total.toFixed(2));
    });
});
