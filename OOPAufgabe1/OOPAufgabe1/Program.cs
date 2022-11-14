using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stammkunde = false;
            double BMenge = 0;
            double rabatt = 0;
            double betrag = 0;
            double ergebnis = 0;
            int regel;

            // Eingabe
            Console.Write("Betrag: ");
            betrag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie ob kunde ist stammkunde oder nicht (true, false)");
            stammkunde = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Bitte geben Sie die Bestellung menge: ");
            BMenge = Convert.ToDouble(Console.ReadLine());

            // Verarbeitung
            if (stammkunde)
            {
                if (BMenge>= 1000)
                {
                    rabatt = 15;
                    regel = 4;
                }
                else
                {
                    rabatt = 10;
                    regel = 3;
                }
            }
            else
            {
                if (BMenge>= 1000)
                {
                    rabatt = 10;
                    regel = 2;
                }
                else
                {
                    rabatt = 0;
                    regel = 1;
                }
            }
		    ergebnis = betrag - ( betrag * rabatt / 100 );
            // Ausgabe
            Console.WriteLine("Ergebnis: {0}, Regel: {1}, Rabatt: {2}",ergebnis, regel, rabatt );
            Console.ReadLine();
        }
    }
}
