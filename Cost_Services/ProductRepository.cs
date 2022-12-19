using Cost_Models;
using Cost_Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Services
{
    public class ProductRepository : IProductRepository
    {
        public Task<ProductDTO> Create(ProductDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetAll(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> Update(ProductDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
