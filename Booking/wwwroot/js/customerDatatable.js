$(document).ready(function () {
    $('#customerDatatable').dataTable({
        pageLength: 5,
        lengthMenu: [[5, 10, 20, -1], [5, 10, 20, 'all']]
    });
});