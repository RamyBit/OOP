using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            string[] fischfresser = { "Seelöwen", "Eisbär" };
            string[] fischfutterfresser = {"Guppys", "Seeferde" };
            string[] allerfresser = { "Cheeta", "Grizzly", "Braunbär", "Schimansen Weiblichen" };
            string[] fleischfresser = { "Löwen", "Löwiennen", "Cobras", "Pythons", "Alligator" };
            string[] pflanzenfresser = { "Orang-Utan", "Orang-Utan Weiblchen", "Pferd", "Kamel", "Zebras" };
            int tierlength = fischfresser.Length + fischfutterfresser.Length + allerfresser.Length + fleischfresser.Length + pflanzenfresser.Length;
            string[] tiere = new string[tierlength];
            tiere = fischfresser.Concat(fischfutterfresser).Concat(allerfresser).Concat(fleischfresser).Concat(pflanzenfresser).ToArray();
            foreach (string name in tiere)
            {
                Console.WriteLine(counter +" "+ name);
                counter++;
            }
            Console.WriteLine("Wahlen Sie ein Tier aus?");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            foreach  (string tierinlist in fischfresser)
            {
                if (tierinlist == tiere[eingabe])
                {
                    Fischfresser fischfresser1 = new Fischfresser();
                    fischfresser1.Fischfuttern();
                }
            }
            {

            }

            Console.ReadLine();
       
        }
    }
}
