using Cost_Models;
using Cost_Services.IRepository;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cost_DataAccess;

namespace Cost_Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

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

        public async Task<IEnumerable<ProductDTO>> GetAll(string userId)
        {
            if (userId != null && userId != "")
            {
                return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>
                (_db.Products.Where(x => x.UserId == userId));
            }
            else { throw new NotImplementedException(); }
        }

        public Task<ProductDTO> Update(ProductDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
