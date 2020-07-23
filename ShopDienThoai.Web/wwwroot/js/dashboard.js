var brand = {} || brand;
var category = {} || category;
$(document).ready(function () {
    brand.init();
    category.init();
});

brand.init = function () {
    brand.drawTable();
};

brand.drawTable = function () {
    $.ajax({
        url: "/BrandsManager/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#brandsTable tbody').empty();
            $.each(data.result, function (i, v) {
                $('#brandsTable tbody').append(
                    `<tr>
                        <td>${v.brandId}</td>
                        <td>${v.name}</td>
                        <td>
                            <a href="javascripts:;" class="btn btn-primary"
                                       onclick="brand.get(${v.brandId})"><i class="fas fa-edit"></i></a> 
                            <a href="javascripts:;" class="btn btn-danger"
                                        onclick="brand.delete(${v.brandId}, '${v.name}')"><i class="fas fa-trash"></i></a>
                        </td>
                    </tr>`
                );
            });
            $('#brandsTable').DataTable();
        }
    });
};

brand.get = function (id) {
    $.ajax({
        url: `/BrandsManager/Get/${id}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('.modal-title').text("Đổi tên thương hiệu");
            $('#BrandName').val(data.result.name);
            $('#BrandId').val(data.result.brandId);
            $('#addEditBrand').modal('show');
        }
    });
};

brand.save = function () {
    var brandObj = {};
    brandObj.Name = $('#BrandName').val();
    brandObj.BrandId = parseInt($('#BrandId').val());
    $.ajax({
        url: `/BrandsManager/Save/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(brandObj),
        success: function (data) {
            $('#addEditBrand').modal('hide');
            bootbox.alert(data.result.message);
            brand.drawTable();
        }
    });
};

brand.delete = function (id, name) {
    bootbox.confirm({
        title: "Xoá thương hiệu",
        message: "Bạn có thực sự muốn xoá thương hiệu " + name + "?",
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
                    url: `/BrandsManager/Delete/${id}`,
                    method: "GET",
                    dataType: "json",
                    success: function (data) {
                        bootbox.alert(data.result.message);
                        brand.drawTable();
                    }
                });
            }
        }
    });
};

brand.reset = function () {
    $('#BrandName').val("");
    $('#BrandId').val(0);
}

AddEditBrand = function () {
    brand.reset();
    $('.modal-title').text("Thêm mới thương hiệu");
    $('#addEditBrand').modal('show');
};

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
            $.each(data.result, function (i, v) {
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
            $('#CategoryName').val(data.result.name);
            $('#CategoryId').val(data.result.categoryId);
            $('#addEditCategory').modal('show');
        }
    });
};

category.save = function () {
    var categoryObj = {};
    categoryObj.Name = $('#CategoryName').val();
    categoryObj.CategoryId = parseInt($('#CategoryId').val());
    $.ajax({
        url: `/CategoriesManager/Save/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(categoryObj),
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