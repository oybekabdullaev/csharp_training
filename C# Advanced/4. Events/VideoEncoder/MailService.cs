using System;

namespace VideoEncoder
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Video {0} is encoded. Sending an email...", args.Video.Title);
        }
    }
}
