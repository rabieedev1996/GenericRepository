using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Infrastructure.Interface;

namespace CodeFirst.Infrastructure.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
