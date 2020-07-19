using System;
using System.Collections.Generic;
using System.Text;
using ShopDienThoai.Domain;
using ShopDienThoai.Domain.Response;
using ShopDienThoai.Domain.Request;

namespace ShopDienThoai.DAL.Interface
{
    public interface ICategoryRepository
    {
        IList<Category> Get();
        Category Get(int id);
        int EditCategory(Category category);
        int CreateCategory(CategoryViewModel model);
        bool RemoveCategory(int id);
    }
}
