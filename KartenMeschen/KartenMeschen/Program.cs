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

            Stack<Karte> staple1 = new Stack<Karte>();
            Stack<Karte> staple2 = new Stack<Karte>();
            Stack<Karte> staple3 = new Stack<Karte>();

            foreach (string karteWert in kartenWert)
            {
                staple1.Push(new Karte() { Wert = karteWert, Farbe = "Pik" });
            }
            foreach (string karteWert in kartenWert)
            {
                staple1.Push(new Karte() { Wert = karteWert, Farbe = "Herz" });
            }

            foreach (Karte karte1 in collection)
            {

            }

            foreach (Karte karte in staple3)
            {
                Console.WriteLine($"{karte.Wert} {karte.Farbe}");
            }
            
        }
    }
}
