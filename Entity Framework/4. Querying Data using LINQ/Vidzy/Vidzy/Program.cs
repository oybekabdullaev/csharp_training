

using System;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            var actionMoviesSortedByName = context.Videos
                .Where(v => v.Genre.Name == "Action")
                .OrderBy(v => v.Name);

            Console.WriteLine("Action movies sorted by name:");
            
            foreach (var movie in actionMoviesSortedByName)
            {
                Console.WriteLine(movie.Name);
            }

            var goldDramaMoviesSortedByDate = context.Videos
                .Where(v => v.Classification == Classification.Gold)
                .Where(v => v.Genre.Name == "Drama")
                .OrderByDescending(v => v.ReleaseDate);

            Console.WriteLine();
            Console.WriteLine("Gold drama movies sorted by date:");

            foreach (var movie in goldDramaMoviesSortedByDate)
            {
                Console.WriteLine(movie.Name);
            }

            var allMoviesWithGenre = context.Videos
                .Select(v => new
                {
                    MovieName = v.Name,
                    Genre = v.Genre.Name
                });

            Console.WriteLine();
            Console.WriteLine("All movies with genre:");

            foreach (var movie in allMoviesWithGenre)
            {
                Console.WriteLine("{0}: {1}", movie.MovieName, movie.Genre);
            }

            var allMoviesGroupedByClassification = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new 
                { 
                    Classification = g.Key.ToString(), 
                    Movies = g.OrderBy(v => v.Name) 
                });

            Console.WriteLine();
            Console.WriteLine("All movies grouped by classification");

            foreach (var group in allMoviesGroupedByClassification)
            {
                Console.WriteLine("Classification: {0}", group.Classification);

                foreach (var movie in group.Movies)
                {
                    Console.WriteLine(movie.Name);
                }
            }

            var classificationsWithCount = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Name = g.Key.ToString(),
                    Count = g.Count()
                })
                .OrderBy(g => g.Name);

            Console.WriteLine();
            Console.WriteLine("Classifications with count:");

            foreach (var classification in classificationsWithCount)
            {
                Console.WriteLine("{0}: {1}", classification.Name, classification.Count);
            }

            var genresWithVideosCount = context.Genres
                .Select(g => new
                {
                    Name = g.Name,
                    Count = g.Videos.Count()
                })
                .OrderByDescending(g => g.Count);

            Console.WriteLine();
            Console.WriteLine("Genres with video counts:");

            foreach (var genre in genresWithVideosCount)
            {
                Console.WriteLine("{0}: {1}", genre.Name, genre.Count);
            }

            Console.ReadLine();
        }
    }
}
