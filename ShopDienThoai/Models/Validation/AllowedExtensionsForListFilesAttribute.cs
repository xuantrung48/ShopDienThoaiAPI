﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TheGioiDienThoai.Models.Validation
{
    public class AllowedExtensionsForListFilesAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        public AllowedExtensionsForListFilesAttribute(string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is List<IFormFile> files)
            {
                foreach(var file in files)
                {
                    var extension = Path.GetExtension(file.FileName);
                    if (!_extensions.Contains(extension.ToLower()))
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }

            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Có ít nhất 1 tập tin không hợp lệ!";
        }
    }
}
