using System;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

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
