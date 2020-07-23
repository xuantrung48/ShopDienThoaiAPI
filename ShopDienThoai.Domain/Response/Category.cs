using System.ComponentModel.DataAnnotations;

namespace ShopDienThoai.Domain.Response
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Nhập vào tên danh mục!")]
        public string Name { get; set; }
    }
}
