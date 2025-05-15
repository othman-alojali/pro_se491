using pro_se491.Data.Entities;

namespace pro_se491.Components.Pages.Bookcomponents
{
    public class BookDesignServices
    {
        public List<Book> GetBook()
        {

            return
            [
                new Book
                {
                    Id = Guid.NewGuid(),

                    Title = "Math1",

                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Math2",
                }

            ];

        }
        public Book GetAuthorById(Guid Id)
        {
            return new Book
            {
                Id = Id,
                Title = "Math3"
            };
        }
        public Book Save(Book book )
        {

            return book;
        }
        public void Delete(Book book )
        {


        }
        public Book Update(Book book )
        {
            return book;
        }
    }
}

