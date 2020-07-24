using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL.Interface
{
    public interface IImageService
    {
        Task<IEnumerable<Image>> Get();
        Task<Image> Get(int id);
        Task<IEnumerable<Image>> GetImagesByProductId(string productId);
        Task<ActionImageResult> Save(Image image);
        Task<ActionImageResult> Delete(int id);
    }
}
