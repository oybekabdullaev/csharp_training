using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            
            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();

            Console.WriteLine("Time taken: {0:ss\\.fff} seconds", stopwatch.Duration);
        }
    }
}
