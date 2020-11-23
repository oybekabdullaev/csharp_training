using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post
            {
                Title = "New post",
                Description = "Description"
            };
            
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();

            Console.WriteLine("The post has {0} votes", post.Vote);
        }
    }
}
