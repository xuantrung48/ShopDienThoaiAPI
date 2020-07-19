using Dapper;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ShopDienThoai.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {

        public Category Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            Category category = SqlMapper.Query<Category>(conn, "GetCategory", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return category;
        }

        public IList<Category> Get()
        {
            IList<Category> categories = SqlMapper.Query<Category>(conn, "GetCategories", commandType: CommandType.StoredProcedure).ToList();
            return categories;
        }

        public bool RemoveCategory(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", id);
                bool removeSuccess = SqlMapper.ExecuteScalar<bool>(conn, "RemoveCategory", parameters, commandType: CommandType.StoredProcedure);
                return removeSuccess;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int EditCategory(Category category)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", category.CategoryId);
                parameters.Add("@Name", category.Name);
                int id = SqlMapper.ExecuteScalar<int>(conn, "EditCategory", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int CreateCategory(CategoryViewModel model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", model.Name);
                int id = SqlMapper.ExecuteScalar<int>(conn, "CreateCategory", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
