using Cost_DataAccess;

namespace Cost_Services.IRepository
{
    public  interface IComponentRepository
    {
        Task AddComponentAsync(Component component);
        Task UpdateComponentAsync(Component component);
        Task<Component>? GetComponentByIdAsync(int componentId);
        Task DeleteComponentAsync(int componentId);
        Task<IEnumerable<Component>> GetComponentsByUserIdAsync(string userId);

        // Task<IEnumerable<Component>> GetComponentsByCategAsync(string user, string category);
    }
}
