namespace pro_se491.Data.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
     
        public Author Author { get; set; }

    }
}