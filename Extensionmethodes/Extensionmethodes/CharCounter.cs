using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethodes
{
    static class CharCounter
    {
        public static int CountChar(this string s)
        {
            int count = 0;
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            else
            {
                foreach (char ch in s)
                {
                    if (ch != ' ')
                    {
                        count++;
                    }
                    
                }
            }
            return count;
        }
    }
}
