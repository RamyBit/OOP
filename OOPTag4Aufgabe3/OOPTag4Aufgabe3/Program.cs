using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTag4Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int spalte;
            int zeilen;
            string bezeichnung;
            Console.Write("Geben Sie Anzahl der Zeilen:");
            zeilen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie Anzahl je Spalte: ");
            spalte = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie einer Bezeichnung: ");
            bezeichnung = Console.ReadLine();
            organziern(spalte, zeilen, bezeichnung);
            Console.Read();
        }
        static void organziern(int spalte, int zeilen, string bezeichnung)
        {
            for(int i=1; i<= spalte; i++)
            {
                for (int j=1; j <= zeilen; j++)
                {
                    Console.Write(bezeichnung + " " + i * j + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
