using AutoMapper;
using ProjectKaits.Dtos;
using ProjectKaits.Model;

namespace ProjectKaits.Service
{
    public class ProductService : IProductService
    {
        private readonly KaitsDBContext _dbContext;

        private readonly IMapper _mapper;

        public ProductService(KaitsDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IList<ProductDto> GetProducts()
        {
            var list = _dbContext.Products
                                .ToList();

            return _mapper.Map<IList<ProductDto>>(list);
        }

        public void SaveProduct(SaveProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _dbContext.Products.Add(product);

            _dbContext.SaveChanges();
        }

    }

    public interface IProductService
    {
        IList<ProductDto> GetProducts();

        void SaveProduct(SaveProductDto productDto);
    }
}
