using System.Collections.Generic;

namespace BookRepository
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 11},
                new Book() {Title = "Title 2", Price = 6},
                new Book() {Title = "Title 3", Price = 4}
            };
        }
    }
}
