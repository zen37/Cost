using AutoMapper;
using Cost_DataAccess;
using Cost_Models;
using Cost_Services.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Services
{
    public class ComponentRepository : IComponentRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ComponentRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public Task<ComponentDTO> Create(ComponentDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ComponentDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ComponentDTO>> GetAll(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ComponentDTO> Update(ComponentDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
