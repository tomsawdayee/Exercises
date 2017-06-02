using System.Collections.Generic;

namespace Fibonacci
{
    //Calculates nth Fibonacci series in several ways
    public class Fibonacci
    {
        public static Dictionary<int, int> Calcs { get; set; }

        public Fibonacci()
        {
            Calcs = new Dictionary<int, int>();
        }

        //Standard Recursive
        public int FiboRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FiboRecursive(n - 1) + FiboRecursive(n - 2);
        }

        //Standard Iterative
        public int FiboIterative(int n)
        {
            var prev1 = 0;
            var prev2 = 1;
            var temp = 0;
            for (var i = 0; i < n; i++)
            {
                temp = prev1 + prev2;
                prev2 = prev1;
                prev1 = temp;

            }
            return temp;
        }

        //Optimized Recursive
        public int FiboRecursiveOptimized(int n)
        {
            if (n <= 1)
                return n;
            if (Calcs.ContainsKey(n))
                return Calcs[n];

            var prev1 = FiboRecursiveOptimized(n - 1);
            var prev2 = FiboRecursiveOptimized(n - 2);

            Calcs.Add(n, prev1 + prev2);

            return prev1 + prev2;
        }
    }
}
