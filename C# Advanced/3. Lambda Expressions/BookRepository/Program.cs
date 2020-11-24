using System;
using System.Collections.Generic;

namespace BookRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = BookRepository.GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine("Title: {0}, price: {1}", book.Title, book.Price);
            }
        }
    }
}
