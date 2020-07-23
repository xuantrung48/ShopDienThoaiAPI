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
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public async Task<Brand> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BrandId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<Brand>(cnn: conn, sql: "GetBrand", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Brand>> Get()
        {
            return await SqlMapper.QueryAsync<Brand>(conn, "GetBrands", commandType: CommandType.StoredProcedure);
        }

        public async Task<ActionBrandResult> Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BrandId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<ActionBrandResult>(cnn: conn, sql: "DeleteBrand", param: parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<ActionBrandResult> Save(Brand brand)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BrandId", brand.BrandId);
                parameters.Add("@Name", brand.Name);
                return await SqlMapper.QueryFirstOrDefaultAsync<ActionBrandResult>(cnn: conn, sql: "SaveBrand", param: parameters, commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return new ActionBrandResult()
                {
                    BrandId = 0,
                    Message = "Có lỗi xảy ra, xin thử lại!"
                };
            }
        }
    }
}
