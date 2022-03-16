using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Infrastructure.Interface;

namespace CodeFirst.Infrastructure.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
