using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hallo Welt";
            s.CountChar();
            Console.WriteLine("Hallo Welt".CountChar());
            Console.ReadLine();
        }
    }
}
