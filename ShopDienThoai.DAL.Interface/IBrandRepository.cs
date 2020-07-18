using System;
using System.Collections.Generic;
using System.Text;
using ShopDienThoai.Domain;
using ShopDienThoai.Domain.Response;
using ShopDienThoai.Domain.Request;

namespace ShopDienThoai.DAL.Interface
{
    public interface IBrandRepository
    {
        IList<Brand> Get();
        Brand Get(int id);
        int EditBrand(Brand brand);
        int CreateBrand(BrandViewModel model);
        bool RemoveBrand(int id);
    }
}
