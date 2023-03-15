// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var table = $('#dtBasicExample');
    var rowsPerPage = 10;
    var currentPage = 1;

    function updateTable(pageNumber) {
        var start = (pageNumber - 1) * rowsPerPage;
        var end = start + rowsPerPage;

        table.find('tbody tr').hide();
        table.find('tbody tr').slice(start, end).show();

        // Update current page indicator
        $('#paging .current-page').text(pageNumber);

        // Remove the active class from all page buttons
        $('#paging .page').removeClass('active');

        // Add the active class to the current page button
        $('#paging .page').eq(pageNumber - 1).addClass('active');


        // Disable/enable previous/next buttons
        if (pageNumber == 1) {
            $('#paging .previous').prop('disabled', true);
        } else {
            $('#paging .previous').prop('disabled', false);
        }

        var totalPages = Math.ceil(table.find('tbody tr').length / rowsPerPage);

        if (pageNumber == totalPages) {
            $('#paging .next').prop('disabled', true);
        } else {
            $('#paging .next').prop('disabled', false);
        }
    }

    // Initialize paging elements
    var paging = $('#paging');

    paging.append('<button class="paging-button previous" disabled>Previous</button>');

    var totalPages = Math.ceil(table.find('tbody tr').length / rowsPerPage);

    for (var i = 1; i <= totalPages; i++) {
        paging.append('<button class="paging-button page">' + i + '</button>');
    }

    paging.append('<button class="paging-button next">Next</button>');


        // Attach event listeners to paging elements
        paging.on('click', '.page', function () {
            var pageNumber = parseInt($(this).text());
            updateTable(pageNumber);
            currentPage = pageNumber;
        });

        paging.on('click', '.next', function () {
            var pageNumber = currentPage + 1;
            updateTable(pageNumber);
            currentPage = pageNumber;
        });

        paging.on('click', '.previous', function () {
            var pageNumber = currentPage - 1;
            updateTable(pageNumber);
            currentPage = pageNumber;
        });

        // Show initial page
        updateTable(currentPage);

});