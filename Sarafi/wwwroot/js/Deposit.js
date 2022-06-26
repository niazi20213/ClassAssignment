var dataTable;
$(document).ready(function () {
    LoadCustomerListForDeposit();




});


function LoadCustomerListForDeposit() {

    dataTable = $('#tblcustomerlistfordeposit').DataTable({
        "ajax": {
            "url": "/Changer/Customer/GetAll"
        },
        "columns": [
            { "data": "customerCode", "width": "15%" },
            { "data": "name", "width": "15%" },
            { "data": "fname", "width": "15%" },
            { "data": "tazkeraNumber", "width": "15%" },
            { "data": "phoneNo", "width": "15%" },
            {
                "data": "customerCode",
                "render": function (data) {

                    return `<div class="w-75" role="group">
                <a   class="btn btn-outline-success" title="Deposit" data-toggle="modal" data-target="#DepositModal" data-whatever="@getbootstrap"><i class="bi bi-coin"></i></a></div>`
                }
                , "width": "5%"
            }


        ]
    });
}


