using System;
using System.Runtime.Serialization;

namespace YouTubeApi
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}