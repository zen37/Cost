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
            var dt = DateTime.Now;
            var obj = _mapper.Map<ComponentDTO, Component>(objDTO);

            obj.CreatedBy = objDTO.UserId;
            obj.CreatedTimestamp = dt;
            obj.UpdatedBy = objDTO.UserId;
            obj.BasePrice = objDTO.BasePrice;
            obj.UpdatedTimestamp = dt;

            var addedObj = _db.Components.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Component, ComponentDTO>(addedObj.Entity);
        }

        public async Task<ComponentDTO> Update(ComponentDTO objDTO)
        {
            var objFromDb = await _db.Components.FirstOrDefaultAsync(u => u.ComponentId == objDTO.ComponentId);
            if (objFromDb != null) 
            {
                objFromDb.Name  = objDTO.Name;
                objFromDb.Price = objDTO.Price;
                objFromDb.UoM   = objDTO.UoM;
                objFromDb.BasePrice = objDTO.BasePrice;
                objFromDb.Other = objDTO.Other;

                objFromDb.UpdatedBy         = objDTO.UserId;
                objFromDb.UpdatedTimestamp  = DateTime.Now;

                _db.Components.Update(objFromDb);
                await _db.SaveChangesAsync();
                
                return _mapper.Map<Component, ComponentDTO>(objFromDb);
            }
            return objDTO;
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Components.FirstOrDefaultAsync(u => u.ComponentId == id);
            if (obj != null)
            {
                _db.Components.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ComponentDTO> Get(int id)
        {
            var obj = await _db.Components.FirstOrDefaultAsync(u => u.ComponentId == id);
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
                (_db.Components.Where(x => x.UserId == userId));
            }
            else { throw new NotImplementedException(); }
        }
    }
}
