namespace pro_se491.Data.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Book> Books { get; set; } = [];
    }
}