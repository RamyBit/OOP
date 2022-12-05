using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace PiratesCoveLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Golfer boris = new Golfer { Name = "Boris" };
            Golfer david = new Golfer { Name = "David" };
            Golfer jermey = new Golfer { Name = "Jermey" };
            Golfer richard = new Golfer { Name = "Richard" };
            Golfer james = new Golfer { Name = "James" };

            Bus doubleTheFun = new Bus();
            Karte piratsRoudTrip = new Karte();
            Queue<Golfer> einsteigendeGolfers = new Queue<Golfer>();
            einsteigendeGolfers.Enqueue(boris);
            einsteigendeGolfers.Enqueue(david);
            einsteigendeGolfers.Enqueue(jermey);
            einsteigendeGolfers.Enqueue(richard);
            einsteigendeGolfers.Enqueue(james);

            doubleTheFun.einsteigen(einsteigendeGolfers);

            Console.WriteLine("Die Personen, die noch in der Bus sind, sind: ");
            foreach (Golfer person in doubleTheFun.Golfers)
            {
                Console.WriteLine(person.Name);
            }
           // doubleTheFun.fahren(1,10 , piratsRoudTrip);
            //Console.WriteLine(doubleTheFun.AktuelleStation);
            Zeigen(doubleTheFun, piratsRoudTrip);
            
            Console.ReadLine();
        }
        static void Zeigen(Bus bus, Karte karte)
        {
            for (int i = 0; i < karte.Lange; i++)
            {
                int einkunft = i + 1;
                bus.fahren(bus.Pos, einkunft, karte);
                Console.Write("=>" + bus.AktuelleStation);
            }
            
           
        }
    }
}
