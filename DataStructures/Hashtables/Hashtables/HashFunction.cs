using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class HashFunction
    {
        public int WordValue(string word)
        {
            int total = 0;
            foreach (char c in word)
            {
                total += c;
            }

            return total;
        }
    }
}