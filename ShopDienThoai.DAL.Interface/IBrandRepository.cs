using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.DAL.Interface
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> Get();
        Task<Brand> Get(int id);
        Task<ActionBrandResult> Save(Brand brand);
        Task<ActionBrandResult> Delete(int id);
    }
}
