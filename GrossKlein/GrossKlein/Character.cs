using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossKlein
{
    class Character
    {
        static public void UpperCase(string eingabe)
        {
            string ausgabe;
            ausgabe = eingabe.ToUpper();
            Console.WriteLine(ausgabe);
        }
        static public void LowerCase(string eingabe)
        {
            string ausgabe;
            ausgabe = eingabe.ToLower();
            Console.WriteLine(ausgabe);
        }
        static public void UpperLower(string eingabe)
        {
            string ausgabe = "";
            foreach (var c in eingabe)
            {
                if (char.IsUpper(c))
                    ausgabe += char.ToLower(c);
                else
                    ausgabe += char.ToUpper(c);
            }
            Console.WriteLine(ausgabe);
        }
    }
}
