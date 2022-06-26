var dataTable;
$(document).ready(function () { 
    loadDataTable();
 
});

function loadDataTable() { 
    dataTable = $('#tblcustomer').DataTable({
        "ajax": {
            "url": "/Changer/Customer/GetAll"
        },
        "columns": [
            { "data": "customerCode", "width": "12%" },
            { "data": "name", "width": "15%" },
            { "data": "fname", "width": "15%" },
            { "data": "tazkeraNumber", "width": "10%" },
            { "data": "phoneNo", "width": "10%" },
            { "data": "address", "width": "15%" },
            {
                "data": "customerCode",
                "render": function (data) {
                   
                    return `<div class="w-75" role="group">
                <a   class="btn btn-outline-primary btn-small" title="Edit"  href="/Changer/Customer/Upsert?customercode=${data}"><i class="bi bi-pencil-square"></i></a> |

 <a   class="btn btn-outline-success" title="History" href="/Changer/Customer/Upsert?customercode=${data}"><i class="bi bi-eye"></i></a></div>`
                }
                , "width": "15%"
            }


        ]
    });
}





function Delete(url) {

    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'Delete',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.success(data.message);
                    }

                }
            });
        }
    })
}