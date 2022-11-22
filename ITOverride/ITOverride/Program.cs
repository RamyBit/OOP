using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnjoyAble[] eineContainer = new IEnjoyAble[3];
            Fachinformatiker fachinformatiker = new Fachinformatiker();
            Fiea fiea = new Fiea();
            Fisi fisi = new Fisi();
            eineContainer[0] = fachinformatiker;
            eineContainer[1] = fiea;
            eineContainer[2] = fisi;
            foreach (Fachinformatiker person in eineContainer)
            {
                person.lernen();
            }
            Console.ReadLine();
        }
    }
}
