using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Beipiel
{
    class WordDokument: Dokument,IDruckbar
    {
        public void Drucken()
        {
            Console.WriteLine("Word");
        }
        public void Erstellen()
        {
            Console.WriteLine("Word wird erstellet.");
        }
    }
}
