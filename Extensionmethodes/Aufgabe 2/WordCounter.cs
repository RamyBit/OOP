using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    static class WordCounter
    {
        public static int CountWord(this string s)
        {
            string[] words;
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            else
            {
                words = s.Split(' ');
            }
            return words.Length;
        }
    }
}
