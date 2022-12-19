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
        public async Task<ComponentDTO> Create(ComponentDTO objDTO)
        {
            var obj = _mapper.Map<ComponentDTO, Component>(objDTO);

            obj.CreatedBy = "1@tm.me";
            obj.CreatedTimestamp = DateTime.Now;
            obj.UpdatedBy = "1@tm.me";
            obj.UpdatedTimestamp = DateTime.Now;

            var addedObj = _db.Components.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Component, ComponentDTO>(addedObj.Entity);
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ComponentDTO> Get(int id)
        {
            var obj = await _db.Components.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Component, ComponentDTO>(obj);
            }
            return new ComponentDTO();
        }

        public async Task<IEnumerable<ComponentDTO>> GetAll(string userId)
        {
            if (userId != null && userId != "")
            {
                return _mapper.Map<IEnumerable<Component>, IEnumerable<ComponentDTO>>
                (_db.Components.Where(x => x.UserID == userId));
            }
            else { throw new NotImplementedException(); }
        }

        public Task<ComponentDTO> Update(ComponentDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
