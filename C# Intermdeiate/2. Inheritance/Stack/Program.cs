using System;

namespace Stack
{

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
