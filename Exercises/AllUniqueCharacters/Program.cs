using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllUniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUniqueChars = new StringAllUniqueChars();

            var str = "faxfgnac";
            Console.WriteLine(allUniqueChars.WithAdditionalMemory(str));
            Console.WriteLine(allUniqueChars.WithoutAdditionalMemory(str));
        }
    }
}
