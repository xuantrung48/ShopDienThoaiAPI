﻿using ShopDienThoai.Models.ProductModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopDienThoai.Models.OrderModel
{
    public class OrderDetail
    {
        [Required]
        [Key]
        public string OrderDetailId { get; set; }
        [Required]
        [ForeignKey(nameof(Order))]
        public string OrderId { get; set; }
        public Order Order { get; set; }
        [Required]
        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }
        public Product Product { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Nhập sai giá!")]
        public int Price { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Nhập sai số lượng!")]
        public int Quantity { get; set; }

    }
}
