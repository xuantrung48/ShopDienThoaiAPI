using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Response;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL
{
    public class ProductsListService : IProductsListService
    {
        private readonly IBrandRepository brandRepository;
        private readonly IImageRepository imageRepository;
        private readonly IProductRepository productRepository;

        public ProductsListService(IBrandRepository brandRepository, IImageRepository imageRepository, IProductRepository productRepository)
        {
            this.brandRepository = brandRepository;
            this.imageRepository = imageRepository;
            this.productRepository = productRepository;
        }


        public async Task<ProductsList> Get()
        {
            var products = await productRepository.Get();
            var images = await imageRepository.Get();
            var brands = await brandRepository.Get();
            foreach (var product in products)
            {
                product.Images = images.Where(i => i.ProductId == product.ProductId);
                product.Brand = brands.Where(i => i.BrandId == product.BrandId).FirstOrDefault();
            }
            var productsManager = new ProductsList
            {
                Products = products
            };
            return productsManager;
        }
    }
}
