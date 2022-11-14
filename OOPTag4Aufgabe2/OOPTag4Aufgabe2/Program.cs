using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOPTag4Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwort;
            do
            {
                Messung();
                Console.Write("Möchten Sie weiter machen?");
                antwort = Console.ReadLine();
            } while (antwort != "n");
        }

        static int Durchschnitt(int warmTemp, int kaltTemp)
        {
            return (warmTemp + kaltTemp) / 2; 
        }
        static void Messung()
        {
            int counter = 0;
            do
            {
                Thread.Sleep(1);
                Random tempGen = new Random();
                int temp1 = tempGen.Next(10, 60);
                int temp2 = tempGen.Next(10, 60);
                Console.WriteLine("Kalt tempator ist {0}, warm tempator ist {1}, Durchschnitt ist {2}. ", temp1, temp2,Program.Durchschnitt(temp1, temp2));
                counter++;
            } while (counter <= 20);
        }
    }
}
