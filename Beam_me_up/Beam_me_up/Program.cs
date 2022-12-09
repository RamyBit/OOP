using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Beam_me_up
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Scotty Beam me Up......\n";
            WriteSlowly(text);
            Druiden_Wesen r2dxxx = new Druiden_Wesen(); //{ Name = "R2D111" };
            Mutant_xxx wolferin = new Mutant_xxx() { Name = "Wolferin"};
            Wookie wookie = new Wookie() { Name = "Wookie" };
            BRDEnterpreis brdEnterpreis = new BRDEnterpreis();
            brdEnterpreis.Geschwindigkeit = 900;
            brdEnterpreis.Beamer += brdEnterpreis.OnBeaming;
            brdEnterpreis.Beaming(r2dxxx);
            
            brdEnterpreis.WerIstAnBord();
            Console.ReadLine();
        }
        private static void WriteSlowly(string text)
        {
            string[] words = text.Split(' ');
            Task t = Task.Run(() =>
            {
                foreach (string word in words)
                {
                    foreach (char letter in word)
                    {
                        Console.Write(letter);
                        System.Threading.Thread.Sleep(100);
                    }

                    Console.Write(" ");
                    System.Threading.Thread.Sleep(250);
                }
            });
            t.Wait();
        }

        
    }
}
