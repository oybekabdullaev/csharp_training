using System;
using System.Collections.Generic;
using System.Linq;

namespace BookRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = BookRepository.GetBooks();


            var cheapBooksTitle = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Price)
                .Select(b => b.Title);

            foreach (var title in cheapBooksTitle)
            {
                Console.WriteLine(title);
            }


            var bookFound = books.FirstOrDefault(b => b.Title == "C# Advanced");
            Console.WriteLine(bookFound.Title);

            var pagedBooks = books.Skip(2).Take(2);

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
