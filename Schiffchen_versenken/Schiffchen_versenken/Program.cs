using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Schiffchen_versenken
{
    class Program
    {
        static void Main(string[] args)
        {
            int versuch = 3;
            do
            {
                int[] pos = SchiffPosGen();
                int auswahl;
                Spielfeld(0);
                Console.WriteLine(pos);
                Console.Write("Wahlen Sie die Position: ");
                auswahl = Convert.ToInt32(Console.ReadLine());
                foreach (int item in pos)
                {
                    if (auswahl == item)
                    {
                        Spielfeld(auswahl);
                    }
                    else
                    {
                        Spielfeld(0);
                    }
                }
                versuch++;
            } while (versuch < 4);
        }
        
        static void Spielfeld(int Ziel)
        {
           
            for (int i = 1; i <=16; i++)
            {
                if (i % 4 == 1)
                {
                    Console.WriteLine("\n");
                }
                if (i == Ziel)
                {
                    Console.Write("+" + "\t");
                }
                Console.Write(i + "\t");
            }
        }
        static int[] SchiffPosGen()
        {
            bool marke = true;
            int[] pos = { 0, 0};
            do
            {
                Thread.Sleep(1);
                Random r = new Random();
                int n1 = r.Next(1, 16);
                int n2 = r.Next(1, 16);
                if ((n1 == n2 + 1 && n1 % 4 != 1) || (n1 == n2 + 4))
                {
                    pos[0] = n1;
                    pos[1] = n2;
                    marke = false;
                }
            } while (marke == true);
            return pos;
        }
    }
}
