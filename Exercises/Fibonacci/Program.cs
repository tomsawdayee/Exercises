using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibo = new Fibonacci();
            Console.WriteLine(fibo.FiboRecursiveOptimized(8));
            Console.WriteLine(fibo.FiboRecursive(8));
            Console.WriteLine(fibo.FiboIterative(8));
        }
    }
}
