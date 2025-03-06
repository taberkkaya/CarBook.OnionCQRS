namespace CarBook.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
