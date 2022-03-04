namespace CodeFirst.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { set; get; }
        public bool IsDeleted { set; get; }
        public DateTime LastModifiedDate { get;  set; }
    }
    public class Basket:EntityBase
    {
        public int ProductId { get; set; }
        public int PaymentId { get; set; }
        public Product Product { get; set; }
        public Payment Payment { get; set; }
    }
    public class Category : EntityBase
    {
        [StringLength(50)]
        public string Title { get; set; }
        public IEnumerable<Product> Products { set; get; }
    }
    public class Payment:EntityBase
    {
        public double TotalPrice { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Basket> Baskets { set; get; }

    }
    public class Product : EntityBase
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Basket> Baskets { set; get; }

    }
    public class User : EntityBase
    {
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public IEnumerable<Payment> Payments { set; get; }

    }
}
