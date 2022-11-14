using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwort;
            Console.WriteLine("Gibt es Problem in der Installation und Konfiguration ?");
            antwort = Console.ReadLine();
            if(antwort == "Ja")
            {
                Console.WriteLine("Bitte erneu konfiguraren.");
            }
            else if (antwort == "Nein")
            {
                Console.WriteLine("Ist Festplatte Defekt?");
                antwort = Console.ReadLine();
                if (antwort == "Ja")
                {
                    Console.WriteLine("Festplatte Reklamieren");
                }
                else if (antwort == "Nein")
                {
                    Console.WriteLine("Ist die Kontrolle Defekt?");
                    antwort = Console.ReadLine();
                    if (antwort == "Ja")
                    {
                        Console.WriteLine("kontrolle Reklamieren");
                    }
                    else if(antwort == "Nein"){
                        Console.WriteLine("Keine Lösung gefunden!");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
