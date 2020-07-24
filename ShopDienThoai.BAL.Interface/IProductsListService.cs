using ShopDienThoai.Domain.Response;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL.Interface
{
    public interface IProductsListService
    {
        Task<ProductsList> Get();
    }
}
