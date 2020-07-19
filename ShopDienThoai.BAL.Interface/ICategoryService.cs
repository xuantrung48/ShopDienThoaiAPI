using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDienThoai.BAL.Interface
{
    public interface ICategoryService
    {
        IList<Category> Get();
        Category Get(int id);
        int EditCategory(Category category);
        int CreateCategory(CategoryViewModel model);
        bool RemoveCategory(int id);
    }
}
