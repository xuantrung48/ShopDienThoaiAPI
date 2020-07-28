using System.ComponentModel.DataAnnotations;

namespace ShopDienThoai.Domain.Response
{
    public class Image
    {
        public string ImageId { get; set; }
        public string ImageData { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
