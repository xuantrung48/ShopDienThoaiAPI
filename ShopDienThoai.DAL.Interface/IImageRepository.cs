using ShopDienThoai.Domain.Request.Images;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.DAL.Interface
{
    public interface IImageRepository
    {
        Task<IEnumerable<Image>> Get();
        Task<Image> Get(string id);
        Task<IEnumerable<Image>> GetImagesByProductId(string productId);
        Task<ActionImageResult> Save(UploadImagesRequest image);
        Task<ActionImageResult> Delete(string id);
    }
}
