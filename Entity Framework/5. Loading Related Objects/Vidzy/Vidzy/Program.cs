using System;
using System.Linq;
using System.Data.Entity;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            // var videos = context.Videos.Include(v => v.Genre).ToList();

            var videos = context.Videos.ToList();
            var genreIds = videos.Select(v => v.GenreId);

            context.Genres.Where(g => genreIds.Contains(g.Id)).Load();

            foreach (var video in videos)
            {
                Console.WriteLine("{0}: {1}", video.Name, video.Genre.Name);
            }

        }
    }
}
