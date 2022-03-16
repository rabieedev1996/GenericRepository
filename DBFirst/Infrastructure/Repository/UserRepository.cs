using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Infrastructure.Interface;

namespace CodeFirst.Infrastructure.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
