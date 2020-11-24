using System;
using System.Collections.Generic;

namespace YouTubeApi
{
    public class YouTubeApi
    {
        public static List<Video> GetVideos(string url)
        {
            try
            {
                // Download video from YouTube

                throw new Exception("Some low level error");
            } 
            catch (Exception ex)
            {
                // Log

                throw new YouTubeException("Could not download video from YouTube", ex);
            }

            return new List<Video>();
        }
    }
}
