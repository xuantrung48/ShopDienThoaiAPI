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
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public Brand Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BrandId", id);
            Brand brand = SqlMapper.Query<Brand>(conn, "GetBrand", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return brand;
        }

        public IList<Brand> Get()
        {
            IList<Brand> brands = SqlMapper.Query<Brand>(conn, "GetBrands", commandType: CommandType.StoredProcedure).ToList();
            return brands;
        }

        public bool RemoveBrand(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BrandId", id);
                bool removeSuccess = SqlMapper.ExecuteScalar<bool>(conn, "RemoveBrand", parameters, commandType: CommandType.StoredProcedure);
                return removeSuccess;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int EditBrand(Brand brand)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BrandId", brand.BrandId);
                parameters.Add("@Name", brand.Name);
                int id = SqlMapper.ExecuteScalar<int>(conn, "SaveBrand", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int CreateBrand(BrandViewModel model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", model.Name);
                int id = SqlMapper.ExecuteScalar<int>(conn, "SaveBrand", parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
