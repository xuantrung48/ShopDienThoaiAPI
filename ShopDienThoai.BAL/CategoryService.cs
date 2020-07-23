using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<Category> Get(int id)
        {
            return await categoryRepository.Get(id);
        }

        public async Task<IEnumerable<Category>> Get()
        {
            return await categoryRepository.Get();
        }

        public async Task<ActionCategoryResult> Delete(int id)
        {
            return await categoryRepository.Delete(id);
        }

        public async Task<ActionCategoryResult> Save(Category category)
        {
            return await categoryRepository.Save(category);
        }
    }
}
