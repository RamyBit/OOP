using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            while (true)
            {
                Thread.Sleep(1000); 
                Console.WriteLine("Wasserstand Von Rhein {0}", rhein.Wasserstand);
                Console.WriteLine("Wasserstand Von Donau {0}", donau.Wasserstand);
                Stadt koeln = new Stadt();
                koeln.Name = "Kölen";
                rhein.WasserstandAendern(koeln);
                Stadt duesseldorf = new Stadt() { Name="Düsseldorf"};
                rhein.WasserstandAendern(duesseldorf);
                Schiff rheingold = new Schiff() { Name = "Rheingold" };
                rhein.WasserstandAendern(rheingold);
                Schiff lorelei = new Schiff() { Name = "Lorelei" };
                rhein.WasserstandAendern(lorelei);

                Stadt ulm = new Stadt() { Name = "Ulm" };
                donau.WasserstandAendern(koeln);
                Schiff xaver = new Schiff() { Name = "Xaver" };
                donau.WasserstandAendern(duesseldorf);
                Schiff unserFranz = new Schiff() { Name = "Unser Franz" };
                donau.WasserstandAendern(unserFranz);
                Klaerwerk soeder1 = new Klaerwerk() { Name = "Söder" };
                donau.WasserstandAendern(soeder1);
                Console.WriteLine("=================================================");
            }
            Console.ReadLine();

        }
    }
}
