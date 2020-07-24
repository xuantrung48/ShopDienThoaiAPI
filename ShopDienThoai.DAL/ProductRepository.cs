using Dapper;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ShopDienThoai.DAL
{
    public class ProductRepository : BaseRepository, IProductRepository
    {

        public async Task<Product> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<Product>(cnn: conn, sql: "GetProduct", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await SqlMapper.QueryAsync<Product>(cnn: conn, sql: "GetProducts", commandType: CommandType.StoredProcedure);
        }

        public async Task<ActionProductResult> Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<ActionProductResult>(cnn: conn, sql: "DeleteProduct", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<ActionProductResult> Save(Product product)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", product.ProductId);
                parameters.Add("@Name", product.Name);
                return await SqlMapper.QueryFirstOrDefaultAsync<ActionProductResult>(cnn: conn, sql: "SaveProduct", param: parameters, commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return new ActionProductResult()
                {
                    ProductId = 0,
                    Message = "Có lỗi xảy ra, xin thử lại!"
                };
            }
        }
    }
}
