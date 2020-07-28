using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Request.Images;
using ShopDienThoai.Domain.Request.Products;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IImageRepository imageRepository;

        public ProductService(IProductRepository productRepository,
                                IImageRepository imageRepository)
        {
            this.productRepository = productRepository;
            this.imageRepository = imageRepository;
        }
        public async Task<Product> Get(string id)
        {
            return await productRepository.Get(id);
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await productRepository.Get();
        }

        public async Task<ActionProductResult> Delete(string id)
        {
            return await productRepository.Delete(id);
        }

        public async Task<ActionProductResult> Save(CreateProductRequest product)
        {
            var createProduct = new Product()
            {
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                CPU = product.CPU,
                Description = product.Description, 
                FrontCamera = product.FrontCamera,
                Name = product.Name,
                OS = product.OS,
                Price = product.Price,
                Ram = product.Ram,
                RearCamera= product.RearCamera,
                Remain = product.Remain,
                Rom = product.Rom,
                Screen= product.Screen, 
                ProductId = product.ProductId
            };
            var createProductResult =  await productRepository.Save(createProduct);
            if(createProductResult.ProductId != null)
            {
                if (product.Images != null && product.Images.Length > 0)
                {
                    _ = await imageRepository.Save(new UploadImagesRequest()
                    {
                        Images = product.Images,
                        ProductId = createProductResult.ProductId
                    });

                }
            }
            return createProductResult;
        }
    }
}
