using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Infrastructure.Interface;

namespace CodeFirst.Infrastructure.Repository
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
