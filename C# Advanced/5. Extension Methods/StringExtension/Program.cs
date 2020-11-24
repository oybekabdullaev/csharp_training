using System;

namespace StringExtension
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var post = "This is supposed to be a very very long blog post";

            Console.WriteLine(post.Shorten(5));
        }
    }
}
