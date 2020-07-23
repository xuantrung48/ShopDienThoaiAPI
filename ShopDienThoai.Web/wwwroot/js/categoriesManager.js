var category = {} || category;
$(document).ready(function () {
    category.init();
});

category.init = function () {
    category.drawTable();
};

category.drawTable = function () {
    $.ajax({
        url: "/CategoriesManager/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#categoriesTable tbody').empty();
            $.each(data.categories, function (i, v) {
                $('#categoriesTable tbody').append(
                    `<tr>
                        <td>${v.categoryId}</td>
                        <td>${v.name}</td>
                        <td>
                            <a href="javascripts:;" class="btn btn-primary"
                                       onclick="category.get(${v.categoryId})"><i class="fas fa-edit"></i></a> 
                            <a href="javascripts:;" class="btn btn-danger"
                                        onclick="category.delete(${v.categoryId}, '${v.name}')"><i class="fas fa-trash"></i></a>
                        </td>
                    </tr>`
                );
            });
            $('#categoriesTable').DataTable();
        }
    });
};

category.get = function (id) {
    $.ajax({
        url: `/CategoriesManager/Get/${id}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('.modal-title').text("Đổi tên danh mục");
            $('#CategoryName').val(data.category.name);
            $('#CategoryId').val(data.category.categoryId);
            $('#addEditCategory').modal('show');
        }
    });
};

category.save = function () {
    var category = {};
    category.Name = $('#CategoryName').val();
    category.CategoryId = parseInt($('#CategoryId').val());
    $.ajax({
        url: `/CategoriesManager/Save/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(category),
        success: function (data) {
            $('#addEditCategory').modal('hide');
            bootbox.alert(data.result.message);
            category.drawTable();
        }
    });
};

category.delete = function (id, name) {
    bootbox.confirm({
        title: "Xoá danh mục",
        message: "Bạn có thực sự muốn xoá danh mục " + name + "?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Huỷ'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Xác nhận'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/CategoriesManager/Delete/${id}`,
                    method: "GET",
                    dataType: "json",
                    success: function (data) {
                        bootbox.alert(data.result.message);
                        category.drawTable();
                    }
                });
            }
        }
    });
};

category.reset = function () {
    $('#CategoryName').val("");
    $('#CategoryId').val(0);
}

AddEditCategory = function () {
    category.reset();
    $('.modal-title').text("Thêm mới danh mục");
    $('#addEditCategory').modal('show');
};