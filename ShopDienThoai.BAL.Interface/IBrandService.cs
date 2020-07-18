using ShopDienThoai.Domain;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;

namespace ShopDienThoai.BAL.Interface
{
    public interface IBrandService
    {
        IList<Brand> Get();
        Brand Get(int id);
        int EditBrand(Brand brand);
        int CreateBrand(BrandViewModel model);
        bool RemoveBrand(int id);
    }
}
