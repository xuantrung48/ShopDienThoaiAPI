using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopDienThoai.Domain.Response
{
    public class Image
    {
        [Required]
        public string ImageId { get; set; }
        public string ImageName { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
