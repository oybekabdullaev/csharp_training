using System;

namespace YouTubeApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var videos = YouTubeApi.GetVideos("youtube.com/");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
