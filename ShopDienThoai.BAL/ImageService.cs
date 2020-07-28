using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Request.Images;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository imageRepository;
        public ImageService(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }
        public async Task<Image> Get(int id)
        {
            return await imageRepository.Get(id);
        }

        public async Task<IEnumerable<Image>> Get()
        {
            return await imageRepository.Get();
        }

        public async Task<IEnumerable<Image>> GetImagesByProductId(string productId)
        {
            return await imageRepository.GetImagesByProductId(productId);
        }

        public async Task<ActionImageResult> Delete(int id)
        {
            return await imageRepository.Delete(id);
        }

        public async Task<ActionImageResult> Save(UploadImagesRequest image)
        {
            return await imageRepository.Save(image);
        }
    }
}
