using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Beipiel
{
    class ExcelDokument: Dokument, IDruckbar
    {
        public void Drucken()
        {
            Console.WriteLine("Excel wird ausgedruckt");
        }
        public void Erstellen()
        {
            Console.WriteLine("Excel wird erstellt");
        }
    }
}
