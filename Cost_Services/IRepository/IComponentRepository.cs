using Cost_Models;

namespace Cost_Services.IRepository
{
    public interface IComponentRepository
    {
        public Task<ComponentDTO> Create(ComponentDTO objDTO);
        public Task<ComponentDTO> Update(ComponentDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ComponentDTO> Get(int id);
        public Task<IEnumerable<ComponentDTO>> GetAll(string userId);

        // Task<IEnumerable<Component>> GetComponentsByCategAsync(string user, string category);

    }
}
