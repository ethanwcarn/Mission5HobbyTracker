// Vintage Clothing Tutoring Calculator - jQuery
// IS 413 Mission 5

$(document).ready(function () {
    const HOURLY_RATE = 25.00;

    $('#calculateBtn').on('click', function () {
        const hoursInput = $('#hours');
        const hoursValue = parseFloat(hoursInput.val());
        const errorDiv = $('#hoursError');

        // Reset error display
        errorDiv.hide().text('');

        // Validation: must be a positive number
        if (isNaN(hoursValue) || hoursValue <= 0) {
            errorDiv.text('Please enter a valid positive number of hours.').show();
            $('#total').val('');
            return;
        }

        // Calculate total
        const total = hoursValue * HOURLY_RATE;
        $('#total').val('$' + total.toFixed(2));
    });
});
