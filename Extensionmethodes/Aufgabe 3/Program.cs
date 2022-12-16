using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "In vision of the Dark night \n" +
                "In visions of the dark night I have dreamed of joy departed, But a waking dream of life " +
                "and light Hath left me broken-hearted. ";
            Console.WriteLine(text.AddCopyright());

            Console.ReadLine();
        }
    }
}
