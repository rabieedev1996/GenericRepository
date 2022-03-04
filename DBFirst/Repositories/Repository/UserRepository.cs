using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Repositories.Interface;

namespace CodeFirst.Repositories.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
