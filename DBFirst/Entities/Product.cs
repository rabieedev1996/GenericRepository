namespace CodeFirst.Entities
{
    public class Product : EntityBase
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Basket> Baskets { set; get; }

    }
}
