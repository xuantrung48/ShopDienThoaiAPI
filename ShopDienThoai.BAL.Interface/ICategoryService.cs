using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Get();
        Task<Category> Get(int id);
        Task<ActionCategoryResult> Save(Category category);
        Task<ActionCategoryResult> Delete(int id);
    }
}
