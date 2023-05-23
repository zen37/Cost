using Cost_Models;

namespace Cost_Services.IRepository
{
    public interface IProductComponentRepository
    {
        public Task<ProductComponentDTO> Create(ProductComponentDTO objDTO);
        public Task<ProductComponentDTO> Update(ProductComponentDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ProductComponentDTO> Get(int id);
        public Task<IEnumerable<ProductComponentDTO>> GetAll(int? id=null);
    }
}