using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double kraftstoffmenge = 0, kilometerstand = 0, ergebnis = 0;
            string eingabe;
            Console.Write("kraftstoffmenge: ");
            eingabe = Console.ReadLine();
            kraftstoffmenge = Convert.ToDouble(eingabe);
            Console.Write("Kilometerstand: ");
            kilometerstand = Convert.ToDouble(Console.ReadLine());

            ergebnis = kraftstoffmenge / kilometerstand * 100;


            Console.WriteLine("Verbrauch: " + ergebnis);
            Console.Read();
        }
    }
}
