using System;

namespace VideoEncoder
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Video {0} is encoded. Sending a message...", args.Video.Title);
        }

    }
}
