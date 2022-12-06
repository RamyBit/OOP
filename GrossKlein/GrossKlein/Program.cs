using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossKlein
{
    delegate void CharacterDelegate(string eingabe);
    class Program
    {
        static void Main(string[] args)
        {
            string testText = "Diese Text wird getestet\"Aloha aus HomeOffice\"";
            CharacterDelegate cDelegate;
            cDelegate = Character.LowerCase;
            cDelegate += Character.UpperCase;
            cDelegate += Character.UpperLower;
            cDelegate(testText);
            
            Console.ReadLine();
            
        }
    }
}
