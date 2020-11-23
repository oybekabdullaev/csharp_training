using System;

namespace WorkflowEngine
{
    public class VideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video activity is executed");
        }
    }
}
