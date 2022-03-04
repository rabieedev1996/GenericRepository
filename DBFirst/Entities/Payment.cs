namespace CodeFirst.Entities
{
    public class Payment:EntityBase
    {
        public double TotalPrice { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Basket> Baskets { set; get; }

    }
}
