using CodeFirst.DBContext;
using CodeFirst.Infrastructure.Interface;
using CodeFirst.Infrastructure.Repository;

namespace CodeFirst
{
    public class UnitOfWork
    {
        Context DBContext = new Context();
        IProductRepository productRepository { get; set; }
        IUserRepository userRepository { get; set; }
        ICategoryRepository categoryRepository { get; set; }
        IBasketRepository basketRepository { get; set; }
        IPaymentRepository paymentRepository { get; set; }

        public IProductRepository Products
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(DBContext);
                }
                return productRepository;
            }
        }
        public IUserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(DBContext);
                }
                return userRepository;
            }
        }
        public ICategoryRepository Categories
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(DBContext);
                }
                return categoryRepository;
            }
        }
        public IBasketRepository Basket
        {
            get
            {
                if (basketRepository == null)
                {
                    basketRepository = new BasketRepository(DBContext);
                }
                return basketRepository;
            }
        }
        public IPaymentRepository Payment
        {
            get
            {
                if (paymentRepository == null)
                {
                    paymentRepository = new PaymentRepository(DBContext);
                }
                return paymentRepository;
            }
        }
    }
}
