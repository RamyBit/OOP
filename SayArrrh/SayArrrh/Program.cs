using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayArrrh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pirat> piraten = new List<Pirat>();
            List<Insel> inselen = new List<Insel>();
            Insel insel1 = new Insel();
           

            Insel insel2 = new Insel();
            Pirat pirat1 = new Pirat(insel1);
            pirat1.Name = "Pirat1";
            Pirat pirat2 = new Pirat(insel1);
            pirat2.Name = "Pirat2";
            inselen.Add(insel1);
            inselen.Add(insel2);
            piraten.Add(pirat1);
            piraten.Add(pirat2);
            //pirat1.Bewegen(insel1.GetKneipe().ElementAt(0));
            //pirat2.Bewegen(insel1.GetWalds().ElementAt(0));
            //pirat2.Bewegen(insel1.GetKneipe().ElementAt(0));

            //insel1.ZeigDichPirat();
            //insel1.SpeichernDiese();
            insel2 = Speichern.Einladen();
            insel2.ZeigDichPirat();


            Console.ReadLine();
        }
        public static void Zeigen(List<Pirat> piraten, List<Insel> inseln)
        {
            Insel insel;
            Pirat pirat;
            char key;
            do
            {
                insel = inseln.ElementAt(0);
                insel.ZeigDichPirat();
                Console.WriteLine("1.Wahlen Sie ein Pirat aus?");
                Console.WriteLine("2.Spiel speicher");
                Console.WriteLine("3.Spiel einladen");
                key = Convert.ToChar(Console.ReadLine());
                switch (key)
                {
                   
                    case '1':
                        insel.ZeigDichPirat();
                        Console.WriteLine("1.Wahlen Sie ein Pirat aus?");
                        break;
                    default: 
                        Console.WriteLine("Eingabe Ungutlig");
                        break;
                }
                
                pirat = piraten.ElementAt(key - 1);
                Console.WriteLine("Wo hin Soll ich gehen");
            } while (key != 'X');
        }
    }
}
