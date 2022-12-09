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

            Stadt ulm = new Stadt() { Name = "Ulm"};
            donau.WasserstandAendern(koeln);
            Schiff xaver = new Schiff() { Name = "Xaver" };
            donau.WasserstandAendern(duesseldorf);
            Schiff unserFranz = new Schiff() { Name = "Unser Franz" };
            donau.WasserstandAendern(unserFranz);
            Klaerwerk soeder1 = new Klaerwerk() { Name = "Söder" };
            donau.WasserstandAendern(soeder1);

        }
    }
}
