using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (bedingung) befehl
            for (int i = 1; i < 5; i++) Console.WriteLine("{0}. Ausgabe", i);
            Console.WriteLine("was anderes");
            for (int j = 2; j <= 6; j = j + 2)
            {
                Console.WriteLine("{0}. Ausgabe von Schleife 2", j);
            }

            int[] anderesArray = new int [10];
            int[] meinArray = { 1, 11, 12, 13 };
            int x = 1;
            do
            {
                x++;
                Console.WriteLine("{0}. Ausgabe von While Schleife",x);
            } while (x < 5);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(meinArray[i]);
           
            
            foreach (int item in meinArray)
            {
                Console.WriteLine("{0} Artikel von anderesArray ",item);
            }

            Console.Read();
        }
    }
}
