using AutoMapper;
using Cost_DataAccess;
using Cost_Models;
using Microsoft.EntityFrameworkCore;
using Cost_Services.IRepository;


namespace Cost_Services.Repository
{
    public class ProductComponentRepository : IProductComponentRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProductComponentRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductComponentDTO> Create(ProductComponentDTO objDTO)
        {
            var obj = _mapper.Map<ProductComponentDTO, ProductComponent>(objDTO);
            var addedObj = _db.ProductComponent.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<ProductComponent, ProductComponentDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.ProductComponent.FirstOrDefaultAsync(u => u.ProductId == id);
            if (obj != null)
            {
                _db.ProductComponent.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ProductComponentDTO> Get(int id)
        {
            var obj = await _db.ProductComponent.FirstOrDefaultAsync(u => u.ProductId == id);
            if (obj != null)
            {
                return _mapper.Map<ProductComponent, ProductComponentDTO>(obj);
            }
            return new ProductComponentDTO();
        }

        public async Task<IEnumerable<ProductComponentDTO>> GetAll(int? id = null)
        {
            if (id != null && id > 0)
            {
                return _mapper.Map<IEnumerable<ProductComponent>, IEnumerable<ProductComponentDTO>>
                    (_db.ProductComponent.Where(u=>u.ProductId == id));
            }
            else
            {
                return _mapper.Map<IEnumerable<ProductComponent>, IEnumerable<ProductComponentDTO>>(_db.ProductComponent);
            }
        }

        public async Task<ProductComponentDTO> Update(ProductComponentDTO objDTO)
        {
            var objFromDb = await _db.ProductComponent.FirstOrDefaultAsync(u => u.ProductId == objDTO.ProductId);
            if (objFromDb != null)
            {
                objFromDb.ProductId= objDTO.ProductId;
                objFromDb.ComponentIngredientId = objDTO.ComponentIngredientId;
                objFromDb.Amount = objDTO.Amount;
                //objFromDb.ComponentUoM = objDTO.ComponentUoM;
                //objFromDb.Price = objDTO.Price;
                //Console.WriteLine(objFromDb.Price);
                _db.ProductComponent.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<ProductComponent, ProductComponentDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}