using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Infrastructure.Interface;

namespace CodeFirst.Infrastructure.Repository
{
    public class BasketRepository : BaseRepository<Basket>, IBasketRepository
    {
        public BasketRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
