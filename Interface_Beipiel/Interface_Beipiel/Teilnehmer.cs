using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Beipiel
{
    class Teilnehmer: IDruckbar
    {
        public void Drucken()
        {
            Console.WriteLine("Teinehmer");
        }
        public void Erstellen()
        {
            Console.WriteLine("Teinehmer wird erstellet.");
        }
    }
}
