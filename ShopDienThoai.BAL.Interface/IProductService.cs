using ShopDienThoai.Domain.Request.Products;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> Get();
        Task<Product> Get(string id);
        Task<ActionProductResult> Save(CreateProductRequest product);
        Task<ActionProductResult> Delete(string id);
    }
}
