reset = function () {
    $('#BrandName').val("");
    $('#BrandId').val(0);
}

AddEditBrand = function () {
    reset();
    $('#addEditBrand').modal('show');
};