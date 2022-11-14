using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Beipiel
{
    class PPDokument: IDruckbar
    {
        public void Drucken()
        {
            Console.WriteLine("PP Dokument wird ausgedruckt");
        }
        public void Erstellen()
        {
            Console.WriteLine("PP Dokument wird erstellt");
        }
    }
}
