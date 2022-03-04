using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Entities
{
    public class Category : EntityBase
    {
        [StringLength(50)]
        public string Title { get; set; }
        public IEnumerable<Product> Products { set; get; }
    }
}
