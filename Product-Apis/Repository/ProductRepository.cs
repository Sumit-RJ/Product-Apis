using AutoMapper;
using Product_Apis.DTOs;
using Product_Apis.Models;
using System.Net.WebSockets;

namespace Product_Apis.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;


        public ProductRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ProductDTO AddProduct(ProductDTO product)
        {
            Product prdDto = _mapper.Map<Product>(product);
            _context.Products.Add(prdDto);
            _context.SaveChanges();
            return GetProductById(prdDto.Id);
        }

        public List<ProductDTO> GetAllProducts()
        {
            return _mapper.Map<List<ProductDTO>>(_context.Products.ToList());
        }

        public ProductDTO GetProductById(int id)
        {
            var ss = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<ProductDTO>(ss);
        }
    }
}
