var brand = {} || brand;
$(document).ready(function () {
    brand.init();
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
            $.each(data.brands, function (i, v) {
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
            $('#BrandName').val(data.brand.name);
            $('#BrandId').val(data.brand.brandId);
            $('#addEditBrand').modal('show');
        }
    });
};

brand.save = function () {
    var brand = {};
    brand.Name = $('#BrandName').val();
    brand.BrandId = parseInt($('#BrandId').val());
    $.ajax({
        url: `/BrandsManager/Save/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(brand),
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