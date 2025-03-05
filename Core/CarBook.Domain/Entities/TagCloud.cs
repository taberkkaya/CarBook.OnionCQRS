namespace CarBook.Domain.Entities
{
    public class TagCloud : BaseEntity
    {
        public string Title { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
