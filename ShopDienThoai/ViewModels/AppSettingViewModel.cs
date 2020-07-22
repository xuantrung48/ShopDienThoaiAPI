﻿using Microsoft.AspNetCore.Http;
using ShopDienThoai.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace ShopDienThoai.ViewModels
{
    public class AppSettingViewModel
    {
        [Required(ErrorMessage = "Nhập vào tên trang web!")]
        [StringLength(30, MinimumLength = 5)]
        public string Title { get; set; }
        [StringLength(100, MinimumLength = 5)]
        public string ShortDesc { get; set; }
        public string Logo { get; set; }
        public string Icon { get; set; }
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        [MaxFileSize(1 * 1024 * 1024)]
        public IFormFile LogoFile { get; set; }
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        [MaxFileSize(1 * 1024 * 1024)]
        public IFormFile IconFile { get; set; }
        [Required(ErrorMessage = "Chọn vai trò mặc định cho người dùng!")]
        public string DefaultRoleId { get; set; }
    }
}
