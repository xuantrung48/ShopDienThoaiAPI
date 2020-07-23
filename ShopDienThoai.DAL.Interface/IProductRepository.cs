using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.DAL.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> Get();
        Task<Product> Get(int id);
        Task<ActionProductResult> Save(Product product);
        Task<ActionProductResult> Delete(int id);
    }
}
