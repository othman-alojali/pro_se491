using pro_se491.Data.Entities;

namespace pro_se491.Components.Pages.Authorcomponents
{
    public class AuthorDesignServices
    {
        public List<Author> GetAuthor()
        {

            return
            [
                new Author
                {
                    Id = Guid.NewGuid(),

                    Name = "Othman Alawgali",

                },
                new Author
                {
                    Id = Guid.NewGuid(),
                    Name = "Mohammed Omar",
                }

            ];

        }
        public Author GetAuthorById(Guid Id) 
        {
            return new Author
            {
                Id = Id,
                Name = "othman"
            };
        }
        public Author Save(Author author)
        {

            return author;
        }
        public void Delete(Author author)
        {


        }
        public Author Update(Author author)
        {
            return author;
        }
    }
}
