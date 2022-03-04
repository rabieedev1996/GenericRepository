using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Repositories.Interface;

namespace CodeFirst.Repositories.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
