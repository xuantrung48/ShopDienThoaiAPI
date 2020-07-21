﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDienThoai.Models.ProductModel
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
