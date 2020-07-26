using Dapper;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ShopDienThoai.DAL
{
    public class ImageRepository : BaseRepository, IImageRepository
    {

        public async Task<Image> Get(int id)
    {
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@ImageId", id);
        return await SqlMapper.QueryFirstOrDefaultAsync<Image>(cnn: conn, sql: "GetImage", param: parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<IEnumerable<Image>> Get()
    {
        return await SqlMapper.QueryAsync<Image>(cnn: conn, sql: "GetImages", commandType: CommandType.StoredProcedure);
    }
    public async Task<IEnumerable<Image>> GetImagesByProductId(string productId)
    {
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@productId", productId);
        return await SqlMapper.QueryAsync<Image>(cnn: conn, sql: "GetImagesByProductId", param: parameters, commandType: CommandType.StoredProcedure);
    }
    public async Task<ActionImageResult> Delete(int id)
    {
        DynamicParameters parameters = new DynamicParameters();
        parameters.Add("@ImageId", id);
        return await SqlMapper.QueryFirstOrDefaultAsync<ActionImageResult>(cnn: conn, sql: "DeleteImage", param: parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<ActionImageResult> Save(Image image)
    {
        try
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ImageId", image.ImageId);
            parameters.Add("@Name", image.ImageData);
            return await SqlMapper.QueryFirstOrDefaultAsync<ActionImageResult>(cnn: conn, sql: "SaveImage", param: parameters, commandType: CommandType.StoredProcedure);
        }
        catch (Exception)
        {
            return new ActionImageResult()
            {
                ImageId = 0,
                Message = "Có lỗi xảy ra, xin thử lại!"
            };
        }
    }
}
}
