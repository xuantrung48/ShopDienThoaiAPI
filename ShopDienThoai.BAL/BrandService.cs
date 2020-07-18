using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;

namespace ShopDienThoai.BAL
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;
        public BrandService(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }
        public Brand Get(int id)
        {
            return brandRepository.Get(id);
        }

        public IList<Brand> Get()
        {
            return brandRepository.Get();
        }

        public bool RemoveBrand(int id)
        {
            return brandRepository.RemoveBrand(id);
        }

        public int EditBrand(Brand brand)
        {
            return brandRepository.EditBrand(brand);
        }
        public int CreateBrand(BrandViewModel model)
        {
            return brandRepository.CreateBrand(model);
        }
    }
}
