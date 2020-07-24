using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.BAL.Interface;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.API.Controllers
{
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService imageService;
        public ImagesController(IImageService imageService)
        {
            this.imageService = imageService;
        }

        [HttpGet]
        [Route("api/images/get")]
        public async Task<IEnumerable<Image>> Get()
        {
            return await imageService.Get();
        }
        [HttpGet]
        [Route("api/images/get/{id}")]
        public async Task<Image> Get(int id)
        {
            return await imageService.Get(id);
        }
        [HttpGet]
        [Route("api/images/getimagesbyproductid/{id}")]
        public async Task<IEnumerable<Image>> GetImagesByProductId(string id)
        {
            return await imageService.GetImagesByProductId(id);
        }
        [HttpPost]
        [Route("api/images/save")]
        public async Task<ActionImageResult> Save(Image image)
        {
            return await imageService.Save(image);
        }
        [HttpDelete]
        [Route("api/images/delete/{id}")]
        public async Task<ActionImageResult> Remove(int id)
        {
            return await imageService.Delete(id);
        }
    }
}