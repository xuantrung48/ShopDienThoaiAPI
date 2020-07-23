using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL.Interface
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> Get();
        Task<Brand> Get(int id);
        Task<ActionBrandResult> Save(Brand brand);
        Task<ActionBrandResult> Delete(int id);
    }
}
