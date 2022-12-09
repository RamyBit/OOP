using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flussbeobachter
{
    class Program
    {
        static void Main(string[] args)
        {

            Fluss rhein = new Fluss() { Name = "Rhein" };
            Fluss donau = new Fluss() { Name = "Donau" };
            rhein.WasserStandMesser += rhein.OnWasserstandAendern;
            donau.WasserStandMesser += donau.OnWasserstandAendern;

            Stadt koeln = new Stadt();
            koeln.Name = "Kölen";
            rhein.WasserstandAendern(koeln);
            Stadt duesseldorf = new Stadt();
            rhein.WasserstandAendern(duesseldorf);
            Schiff rheingold = new Schiff() { Name = "Rheingold" };
            rhein.WasserstandAendern(rheingold);
            Schiff lorelei = new Schiff() { Name = "Lorelei" };
            rhein.WasserstandAendern(lorelei);

            
        }
    }
}
