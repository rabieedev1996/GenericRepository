namespace CodeFirst.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { set; get; }
        public bool IsDeleted { set; get; }
        public DateTime LastModifiedDate { get;  set; }
    }
}
