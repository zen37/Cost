using Cost_Models;
using Cost_Services.IRepository;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cost_DataAccess;
using Microsoft.EntityFrameworkCore;

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

        public async Task<ProductDTO> Create(ProductDTO objDTO)
        {
            var dt = DateTime.Now;
            var obj = _mapper.Map<ProductDTO, Product>(objDTO);

            obj.CreatedBy = objDTO.UserId;
            obj.CreatedTimestamp = dt;
            obj.UpdatedBy = objDTO.UserId;
            obj.UpdatedTimestamp = dt;

            var addedObj = _db.Products.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Product, ProductDTO>(addedObj.Entity);
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDTO> Get(int id)
        {
            var obj = await _db.Products.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Product, ProductDTO>(obj);
            }
            return new ProductDTO();
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

        public async Task<ProductDTO> Update(ProductDTO objDTO)
        {
            var objFromDb = await _db.Products.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = objDTO.Name;
                objFromDb.Other = objDTO.Other;
                objFromDb.Cost= objDTO.Cost;

                objFromDb.UpdatedBy = objDTO.UserId;
                objFromDb.UpdatedTimestamp = DateTime.Now;

                _db.Products.Update(objFromDb);
                await _db.SaveChangesAsync();

                return _mapper.Map<Product, ProductDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
