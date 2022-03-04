using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Repositories.Interface;

namespace CodeFirst.Repositories.Repository
{
    public class BasketRepository : GenericRepository<Basket>, IBasketRepository
    {
        public BasketRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
