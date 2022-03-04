using CodeFirst.DBContext;
using CodeFirst.Entities;
using CodeFirst.Repositories.Interface;

namespace CodeFirst.Repositories.Repository
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
