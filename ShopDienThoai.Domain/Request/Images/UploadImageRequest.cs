using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDienThoai.Domain.Request.Images
{
    public class UploadImagesRequest
    {
        public string[] Images { get; set; }
        public string ProductId { get; set; }
    }
}
