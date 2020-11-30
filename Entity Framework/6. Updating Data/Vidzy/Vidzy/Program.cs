using System;
using System.Linq;
using System.Data.Entity;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            AddVideo(new Video
            {
                Name = "Terminator 1",
                GenreId = 2,
                ReleaseDate = new DateTime(1984, 10, 26),
                Classification = Classification.Silver
            });

            AddTags("classics", "drama");

            AddTagsToVideo(1, "classics", "drama", "comedy");

            RemoveTagsFromVideo(1, "comedy");

            RemoveVideo(1);

            RemoveGenre(2);
        }

        static void AddVideo(Video v)
        {
            using (var context = new VidzyContext())
            {
                context.Videos.Add(v);
                context.SaveChanges();
            }
        }

        static void AddTags(params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name));

                foreach (var tagName in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase)))
                        context.Tags.Add(new Tag { Name = tagName });
                }

                context.SaveChanges();
            }
        }

        static void AddTagsToVideo(int videoId, params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();

                foreach (var tagName in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase)))
                        tags.Add(new Tag { Name = tagName });
                }

                var video = context.Videos.Find(videoId);

                tags.ForEach(t => video.AddTag(t));

                context.SaveChanges();
            }
        }

        static void RemoveTagsFromVideo(int videoId, params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                context.Tags.Where(t => tagNames.Contains(t.Name)).Load();

                var video = context.Videos.Find(videoId);

                foreach (var tagName in tagNames)
                {
                    video.RemoveTag(tagName);
                }

                context.SaveChanges();
            }
        }

        static void RemoveVideo(int videoId)
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.SingleOrDefault(v => v.Id == videoId);

                if (video == null)
                    return;

                context.Videos.Remove(video);

                context.SaveChanges();
            }
        }

        static void RemoveGenre(int genreId)
        {
            using (var context = new VidzyContext())
            {
                var genre = context.Genres.Include(g => g.Videos).SingleOrDefault(g => g.Id == genreId);

                if (genre == null)
                    return;

                context.Videos.RemoveRange(genre.Videos);
                context.Genres.Remove(genre);

                context.SaveChanges();
            }
        }
    }
}
