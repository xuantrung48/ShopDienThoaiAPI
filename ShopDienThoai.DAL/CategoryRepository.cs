using Dapper;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDienThoai.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {

        public async Task<Category> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<Category>(cnn: conn, sql: "GetCategory", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Category>> Get()
        {
            return await SqlMapper.QueryAsync<Category>(cnn: conn, sql: "GetCategories", commandType: CommandType.StoredProcedure);
        }

        public async Task<ActionCategoryResult> Delete(int id)
        {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", id);
                return await SqlMapper.QueryFirstOrDefaultAsync<ActionCategoryResult>(cnn: conn, sql: "DeleteCategory", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<ActionCategoryResult> Save(Category category)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", category.CategoryId);
                parameters.Add("@Name", category.Name);
                return await SqlMapper.QueryFirstOrDefaultAsync<ActionCategoryResult>(cnn: conn, sql: "SaveCategory", param: parameters, commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return new ActionCategoryResult()
                {
                    CategoryId = 0,
                    Message = "Có lỗi xảy ra, xin thử lại!"
                };
            }
        }
    }
}
