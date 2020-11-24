using System.Collections.Generic;

namespace BookRepository
{
    public class BookRepository
    {
        public static IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.NET Step by Step", Price = 5 },
                new Book() { Title = "ASP.NET MVC", Price = 9 },
                new Book() { Title = "ASP.NET WEB API", Price = 12 },
                new Book() { Title = "C# Advanced", Price = 7 },
                new Book() { Title = "C# Advanced", Price = 9 }
            };
        }
    }
}
