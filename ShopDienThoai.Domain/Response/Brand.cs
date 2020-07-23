using System.ComponentModel.DataAnnotations;

namespace ShopDienThoai.Domain.Response
{
    public class Brand
    {
        [Required]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Nhập vào tên thương hiệu!")]
        public string Name { get; set; }
    }
}
