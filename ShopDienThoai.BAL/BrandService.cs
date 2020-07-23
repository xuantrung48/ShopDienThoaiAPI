using ShopDienThoai.BAL.Interface;
using ShopDienThoai.DAL.Interface;
using ShopDienThoai.Domain.Request;
using ShopDienThoai.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopDienThoai.BAL
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;
        public BrandService(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }
        public async Task<Brand> Get(int id)
        {
            return await brandRepository.Get(id);
        }

        public async Task<IEnumerable<Brand>> Get()
        {
            return await brandRepository.Get();
        }

        public async Task<ActionBrandResult> Delete(int id)
        {
            return await brandRepository.Delete(id);
        }
        
        public async Task<ActionBrandResult> Save(Brand brand)
        {
            return await brandRepository.Save(brand);
        }
    }
}
