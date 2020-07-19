using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;

namespace ShopDienThoai.BAL
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public Category Get(int id)
        {
            return categoryRepository.Get(id);
        }

        public IList<Category> Get()
        {
            return categoryRepository.Get();
        }

        public bool RemoveCategory(int id)
        {
            return categoryRepository.RemoveCategory(id);
        }

        public int EditCategory(Category category)
        {
            return categoryRepository.EditCategory(category);
        }
        public int CreateCategory(CategoryViewModel model)
        {
            return categoryRepository.CreateCategory(model);
        }
    }
}
