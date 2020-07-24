using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> Get(int id)
        {
            return await productRepository.Get(id);
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await productRepository.Get();
        }

        public async Task<ActionProductResult> Delete(int id)
        {
            return await productRepository.Delete(id);
        }

        public async Task<ActionProductResult> Save(Product product)
        {
            return await productRepository.Save(product);
        }
    }
}
