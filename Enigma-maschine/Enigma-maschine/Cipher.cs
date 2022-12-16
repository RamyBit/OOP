using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_maschine
{
    class Cipher
    {
        public static char Cipherit(char ch, char key)
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

        public static string Encipher(string input, string codeword)
        {
            string output="";
            char ch2;
            int j;
            for (int i = 0; i < input.Length; i++) 
            {
                j = input.Length % codeword.Length;
                ch2 = codeword[j];
                               
                output += Cipherit(input[i],ch2);
                
            }
            return output;
        }

        public static string Decipher(string input, string codeword)
        {
            string output = "";
            char ch2;
            int j;
            for (int i = 0; i < input.Length; i++)
            {
                j = input.Length % codeword.Length;
                ch2 = codeword[j];

                output += Cipherit(input[i], (char)(26 - ch2));

            }
            return output;
        }
    }
}
