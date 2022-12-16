using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    static class Copyright
    {
        public static string AddCopyright (this string s)
        {
            string line = " Bitlc Erkrath";
            string newWork = string.Empty;
            int counter = 0;
            if (string.IsNullOrEmpty(s))
            {
                return "Error";
            }
            else
            {
               
                foreach (char ch in s)
                {
                    if (ch == ' ')
                    {
                        counter++;
                       
                        if(counter % 10 == 0)
                        foreach (char ch2 in line)
                        {
                            newWork += ch2;
                        }
                        newWork += ch;

                    }
                    else
                    {
                        newWork += ch;
                    }
                }
            }
            return newWork;

        }
    }
}
