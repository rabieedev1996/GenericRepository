using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Entities
{
    public class User : EntityBase
    {
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public IEnumerable<Payment> Payments { set; get; }

    }
}
