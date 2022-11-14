using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Badwanne
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahl = 0, max =20, tempsumme =0 , durchschnitt = 0, temp=0;
            do
            {
                anzahl++;
                temp = tempGen();
                tempsumme += temp;
                durchschnitt = tempsumme / anzahl;
                Console.WriteLine("Temp: {0}    Durchschnitt: {1}", temp, durchschnitt);
            } while (anzahl < max + 1);
            Console.Read();
        }
        
        static int tempGen()
        {
            Thread.Sleep(1);
            Random r = new Random();
            int temp = r.Next(10, 60);
            return temp;
        }
    }
}
