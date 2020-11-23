using System;

namespace WorkflowEngine
{
    public class MessagingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Messaging activity is executed");
        }
    }
}
