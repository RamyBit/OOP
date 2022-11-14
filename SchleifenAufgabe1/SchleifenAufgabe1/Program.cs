using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tag05_Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0, gesuchtezahl = 0, versuch = 0;
            Random r = new Random();
            gesuchtezahl = r.Next(1, 100);
            Console.WriteLine("gesuchte Zahl= {0}", gesuchtezahl);

            Console.WriteLine("Raten Sie einen Zahl");
            zahl = Convert.ToInt32(Console.ReadLine());



            while (zahl != gesuchtezahl)
            {

                if (gesuchtezahl > zahl)
                {
                    Console.WriteLine("Gesuchte Zahl ist Größer!");
                }
                else if (gesuchtezahl < zahl)
                {
                    Console.WriteLine("Gesuchte Zahl ist Kleiner!");
                }
                Console.WriteLine("Raten Sie einen Zahl");
                zahl = Convert.ToInt32(Console.ReadLine());
                if (zahl == gesuchtezahl)
                {
                    Console.WriteLine("Gewinnen!");

                }
                versuch++;
            }

            if (versuch <= 5)
            {
                Console.WriteLine("Super!");
            }
            else if (versuch > 5 && versuch < 10)
            {
                Console.WriteLine("gut geraten!");
            }
            else
            {
                Console.WriteLine("Könnte besser sein.");
            }
            Console.Read();
        }
    }
}
