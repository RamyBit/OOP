using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KartenMeschen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kartenWert = {"2", "3","4","5","6","7","8","9","10" +
                    "Bauer","Dame","König","As"};
            string[] farbe = { "Karo", "Herz", "Pik", "Kreuz" };

            Staple staple1 = new Staple();
            Staple staple2 = new Staple();
            Staple staple3 = new Staple();
            staple1.add(kartenWert, farbe[2]);
            staple2.add(kartenWert, farbe[1]);
            staple3.MischenMit(staple1);
            staple3.MischenMit(staple2);
            staple3.Zeigen();
            
            Stack<Karte>[] teilen = new Stack<Karte>[4];
            teilen = staple3.Teilen();
            foreach (var item in teilen)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine("karte wert:{0} ,{1} ", item2.Wert, item2.Farbe);
                }
            }
            Console.WriteLine("===================/Staple nach Abheben/=====================");
            staple3.Abheben(teilen[0], teilen[1], teilen[2], teilen[3]);
            staple3.Zeigen();
            staple3.Teilen();

            Console.ReadLine();
            
        }

      
    }
}
