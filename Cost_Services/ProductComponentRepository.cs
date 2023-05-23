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
            try
            {
                var objFromDb = await _db.ProductComponent.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
                if (objFromDb == null)
                {
                    var objConverted = _mapper.Map<ProductComponentDTO, ProductComponent>(objDTO);
                    await _db.ProductComponent.AddAsync(objConverted);
                }
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                }
            return objDTO;
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.ProductComponent.FirstOrDefaultAsync(u => u.Id == id);
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
                    (_db.ProductComponent.Where(u => u.ProductId == id));
            }
            else
            {
                return _mapper.Map<IEnumerable<ProductComponent>, IEnumerable<ProductComponentDTO>>(_db.ProductComponent);
            }
        }

        public async Task<ProductComponentDTO> Update(ProductComponentDTO objDTO)
        {
            try
            {
                var objFromDb = await _db.ProductComponent.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
                if (objFromDb != null)
                {
                    objFromDb.ProductId = objDTO.ProductId;
                    objFromDb.ComponentIngredientId = objDTO.ComponentIngredientId;
                    objFromDb.ComponentProductId = objDTO.ComponentProductId;
                    objFromDb.Amount = objDTO.Amount;
                    objFromDb.UoM = objDTO.UoM;
                }
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return objDTO;
        }
    }
}