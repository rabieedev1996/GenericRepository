namespace CodeFirst.Entities
{
    public class Basket:EntityBase
    {
        public int ProductId { get; set; }
        public int PaymentId { get; set; }
        public Product Product { get; set; }
        public Payment Payment { get; set; }
    }
}
