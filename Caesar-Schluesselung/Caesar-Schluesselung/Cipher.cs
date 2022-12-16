using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Schluesselung
{
    class Cipher
    {
        public static char Ciphering(char ch, int key)
        {
            char a;
            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                {
                    a = 'A';
                }
                else
                {
                    a = 'a';
                }
                return (char)((((ch + key) - a) % 26) + a);
            }
            else
            {
                return ch;
            }
        }

        public static string Encipher(string input, int key)
        {
            string output="";
            foreach (char ch in input) 
            {
                output += Ciphering(ch, key);
            }
            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
    }
}
