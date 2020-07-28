var brand = {} || brand;
var category = {} || category;
var product = {} || product;
$(document).ready(function () {
    brand.init();
    category.init();
    product.init();
});

digitGrouping = function (price) {
    return price.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".");
};

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
    $('#CategoryName').val('');
    $('#CategoryId').val(0);
}

AddEditCategory = function () {
    category.reset();
    $('.modal-title').text("Thêm mới danh mục");
    $('#addEditCategory').modal('show');
};

product.init = function () {
    product.drawTable();
};

product.drawTable = function () {
    $.ajax({
        url: `/BrandsManager/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data.result, function (i, v) {
                $('#ProductBrandId').append(
                    `<option value="${v.brandId}">${v.name}</option>`
                );
            })
        }
    });
    $.ajax({
        url: `/CategoriesManager/Gets`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data.result, function (i, v) {
                $('#ProductCategoryId').append(
                    `<option value="${v.categoryId}">${v.name}</option>`
                );
            })
        }
    });
    $.ajax({
        url: "/ProductsManager/Gets",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#productsTable tbody').empty();
            $.each(data.result.products, function (_i, p) {
                let imagesHtml = "";
                $.each(p.images, function (_j, i) {
                    imagesHtml += '<a href="http://localhost:49816/images/products/' + i.imageData + '" data-toggle="lightbox" data-gallery="' + p.productId + '" data-title="' + p.name + '"><img src="http://localhost:49816/images/products/' + i.imageData + '" height="50" class="mx-1 my-1"></a>'
                });
                $('#productsTable tbody').append(
                    `<tr>
                        <td>${p.name}</td>
                        <td>${imagesHtml}</td>
                        <td>${p.brand.name}</td>
                        <td>
                            <ul>
                                <li>Màn hình: ${p.screen}</li>
                                <li>OS: ${p.os}</li>
                                <li>CPU: ${p.cpu}</li>
                                <li>Camera trước: ${p.frontcamera}</li>
                                <li>Camera sau: ${p.rearcamera}</li>
                                <li>Ram: ${p.ram}</li>
                                <li>Rom: ${p.rom}</li>
                            </ul>
                        </td>
                        <td>${digitGrouping(p.price)} ₫</td>
                        <td>${p.remain}</td>
                        <td>
                            <a href="javascripts:;" class="btn btn-primary" onclick="product.get('${p.productId}')"><i class="fas fa-edit"></i></a> 
                            <a href="javascripts:;" class="btn btn-danger" onclick="product.delete('${p.productId}', '${p.name}')"><i class="fas fa-trash"></i></a>
                        </td>
                    </tr>`
                );
            });
            $('#productsTable').DataTable();
        }
    });
};

product.get = function (productId) {
    product.reset();
    tinyMCE.triggerSave();
    var imgsNo;
    $.ajax({
        url: `/ImagesManager/GetImagesByProductId/${productId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            imgsNo = data.result.length;
            $.each(data.result, function (i, v) {
                $("#imgsPreview").append(
                    `<img src="${v.imageData}" height="100" class="mx-2 my-2">`
                );
            });
        }
    })
    $.ajax({
        url: `/ProductsManager/Get/${productId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            let product = data.result;
            $('.modal-title').text("Đổi thông tin sản phẩm");
            $('#ProductName').val(product.name);
            $('#ProductId').val(product.productId);
            $("#imgsNo").val(imgsNo);
            $('#ProductPrice').val(product.price);
            $('#ProductBrandId').val(product.brandId);
            $('#ProductCategoryId').val(product.categoryId);
            $('#ProductRemain').val(product.remain);
            tinymce.activeEditor.setContent(product.description);
            $('#ProductScreen').val(product.screen);
            $('#ProductCPU').val(product.cpu);
            $('#ProductOS').val(product.os);
            $('#ProductRearCamera').val(product.rearCamera);
            $('#ProductFrontCamera').val(product.frontCamera);
            $('#ProductRam').val(product.ram);
            $('#ProductRom').val(product.rom);
            $('#addEditProduct').modal('show');
        }
    });
};

product.save = function () {
    tinyMCE.triggerSave();
    var imgsNo = parseInt($("#imgsNo").val());
    var productObj = {};
    productObj.ProductId = $('#ProductId').val();
    productObj.Name = $('#ProductName').val();
    productObj.Price = parseInt($('#ProductPrice').val());
    productObj.BrandId = parseInt($('#ProductBrandId').val());
    productObj.CategoryId = parseInt($('#ProductCategoryId').val());
    productObj.Remain = parseInt($('#ProductRemain').val());
    productObj.Description = $('#ProductDescription').val();
    productObj.Screen = $('#ProductScreen').val();
    productObj.CPU = $('#ProductCPU').val();
    productObj.OS = $('#ProductOS').val();
    productObj.RearCamera = $('#ProductRearCamera').val();
    productObj.FrontCamera = $('#ProductFrontCamera').val();
    productObj.Ram = parseInt($('#ProductRam').val());
    productObj.Rom = parseInt($('#ProductRom').val());
    productObj.Images = [];
    for (let i = 0; i < imgsNo; i++) {
        productObj.Images[i] = $(`#img${i}`).val();
    };
    $.ajax({
        url: `/ProductsManager/Save/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(productObj),
        success: function (data) {
            $('#addEditProduct').modal('hide');
            bootbox.alert(data.result.message);
            product.drawTable();
        }
    });
};

product.delete = function (id, name) {
    bootbox.confirm({
        title: "Xoá sản phẩm",
        message: "Bạn có thực sự muốn xoá sản phẩm " + name + "?",
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
                    url: `/ProductsManager/Delete/${id}`,
                    method: "GET",
                    dataType: "json",
                    success: function (data) {
                        bootbox.alert(data.result.message);
                        product.drawTable();
                    }
                });
            }
        }
    });
};

product.reset = function () {
    $("#imgsPreview").empty();
    $("#imgsdata").empty();
    $('#ProductId').val('');
    $('#ProductName').val('');
    $('#ProductPrice').val('');
    $('#ProductBrandId').val('');
    $('#ProductCategoryId').val('');
    $('#ProductRemain').val('');
    tinymce.activeEditor.setContent('');
    $('#ProductScreen').val('');
    $('#ProductCPU').val('');
    $('#ProductOS').val('');
    $('#ProductRearCamera').val('');
    $('#ProductFrontCamera').val('');
    $('#ProductRam').val('');
    $('#ProductRom').val('');
}

AddEditProduct = function () {
    product.reset();
    $('.modal-title').text("Thêm mới sản phẩm");
    $('#addEditProduct').modal('show');
};

readFiles = function () {
    $("#imgsPreview").empty();
    $("#imgsdata").empty();
    if (this.files && this.files[0]) {
        for (let i = 0; i < this.files.length; i++) {
            var FR = new FileReader();

            FR.addEventListener("load", function (e) {
                $("#imgsPreview").append(
                    `<img src="${e.target.result}" height="100" class="mx-2 my-2">`
                );
                $("#imgsdata").append(
                    `<input hidden value="${e.target.result}" id="img${i}">`
                );
            });

            FR.readAsDataURL(this.files[i]);
        };
        $("#imgsdata").append(
            `<input hidden value="${this.files.length}" id="imgsNo">`
        );
    }

}
