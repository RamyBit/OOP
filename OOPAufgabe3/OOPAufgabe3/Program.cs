using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double ek=0;
            double steuer=0;
            bool politiker = false;
            string antwort;
            Console.WriteLine("Sind Sie Politiker?");
            antwort = Console.ReadLine();
            if (antwort == "Ja")
            {
                politiker = true;
            }
            else
            {
                politiker = false;
            }
            if (politiker == false)
            {


                Console.Write("Bitte geben Sie Die Einkomme ein: ");
                ek = Convert.ToDouble(Console.ReadLine());
                if (ek <= 2000)
                {
                    Console.WriteLine("kain Steuer fällig");
                }
                else if (ek >= 2000 && ek <= 5000)
                {
                    steuer = 0.3 * ek;
                    Console.WriteLine("30% fällig der fällig Betrag ist : " + steuer);
                }
                else if (ek > 5000 && ek <= 15000)
                {
                    steuer = 0.2 * ek;
                    Console.WriteLine("20% fällig! der fällig Betrag ist: " + steuer);
                }
                else
                {
                    steuer = 0.05 * ek;
                    Console.WriteLine("5% fällig! der fällig Betrag ist: " + steuer);
                }
            }
            else
            {
                Console.WriteLine("Sie sind Politiker, Keine Betrag fällig.");
            }
            Console.ReadLine();
        }
    }
}
