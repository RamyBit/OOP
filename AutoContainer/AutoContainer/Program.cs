using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] parkplatz = new Auto[4]; // leerer Container
            //Auto-Objekte
            Auto nr1 = new Auto("Volvo");
            Auto nr2 = new Auto("VM");
            Auto nr3 = new Auto("Porsche");
            Auto nr4 = new Auto("Audi");
            // Objekte in Container = Parkplatz speichern
            parkplatz[0] = nr1;
            parkplatz[1] = nr2;
            parkplatz[2] = nr3;
            parkplatz[3] = nr4;

            Console.WriteLine("Ausgabe aus Schleife");
            foreach (Auto auto in parkplatz)
            {
                Console.WriteLine(auto.GetFabrikat());
            }
            // wir zerstören den Containerf Parkplatz auf dem die Auto stehen!
            parkplatz = null;
            // Versuch auf ein Auto auf dem zerstörten Parkplatz zuzufassen
            //Console.WriteLine(parkPlatz[0].Fabrikat); // klappt nicht: Laufzeitfehler !!!
            Console.WriteLine("Container wird zerstört");
            // Doch Autos sind da! das Heißt Aggregation
            Console.WriteLine("Wegen Aggregation gilt weiterhin");
            Console.WriteLine(nr1.GetFabrikat());
            Console.WriteLine(nr2.GetFabrikat());
            Console.WriteLine(nr3.GetFabrikat());
            Console.WriteLine(nr4.GetFabrikat());
            Console.ReadLine();
        }
    }
}
