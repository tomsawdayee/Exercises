using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllUniqueCharacters
{
    public class StringAllUniqueChars
    {
        public bool WithAdditionalMemory(string str) {

            var dict = new Dictionary<char, bool>();

            foreach (var chr in str){
                if (dict.ContainsKey(chr))
                    return false;
                dict.Add(chr, true);
            }

            return true;
        }

        public bool WithoutAdditionalMemory(string str)
        {
            str = string.Concat(str.OrderBy(c => c));

            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                    return false;
            }
            
            return true;
        }
    }
}
