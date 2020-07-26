using ShopDienThoai.Domain.Response;

namespace ShopDienThoai.Domain.Request
{
    class ImageViewModel
    {
        public string ImageData { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
