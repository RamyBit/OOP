using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statischeDinge
{
    class Program
    {
        static void Main(string[] args)
        {
            Teilnehmer.intellenz = 180;
            Console.WriteLine(Teilnehmer.intellenz);

            Teilnehmer t = new Teilnehmer();
            t.bescheidenheit = 0;
        }
    }
}
