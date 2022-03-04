using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Repositories.Interface;

namespace CodeFirst.Repositories.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
