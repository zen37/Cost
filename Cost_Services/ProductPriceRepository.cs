using AutoMapper;
using Cost_DataAccess;
using Cost_Models;
using Microsoft.EntityFrameworkCore;
using Cost_Services.IRepository;


namespace Cost_Services.Repository
{
    public class ProductPriceRepository : IProductPriceRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProductPriceRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductPriceDTO> Create(ProductPriceDTO objDTO)
        {
            var obj = _mapper.Map<ProductPriceDTO, ProductPrice>(objDTO);
            var addedObj = _db.ProductPrices.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<ProductPrice, ProductPriceDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.ProductPrices.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.ProductPrices.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ProductPriceDTO> Get(int id)
        {
            var obj = await _db.ProductPrices.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<ProductPrice, ProductPriceDTO>(obj);
            }
            return new ProductPriceDTO();
        }

        public async Task<IEnumerable<ProductPriceDTO>> GetAll(int? id = null)
        {
            if (id != null && id > 0)
            {
                return _mapper.Map<IEnumerable<ProductPrice>, IEnumerable<ProductPriceDTO>>
                    (_db.ProductPrices.Where(u=>u.ProductId == id));
            }
            else
            {
                return _mapper.Map<IEnumerable<ProductPrice>, IEnumerable<ProductPriceDTO>>(_db.ProductPrices);
            }
        }

        public async Task<ProductPriceDTO> Update(ProductPriceDTO objDTO)
        {
            var objFromDb = await _db.ProductPrices.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.ProductId= objDTO.ProductId;
                objFromDb.ComponentId = objDTO.ComponentId;
                objFromDb.Amount = objDTO.Amount;
                objFromDb.ComponentUoM = objDTO.ComponentUoM;
                objFromDb.Price = objDTO.Price;
                Console.WriteLine(objFromDb.Price);
                _db.ProductPrices.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<ProductPrice, ProductPriceDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}