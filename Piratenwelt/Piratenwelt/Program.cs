using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenwelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Pirates World!");
            GangContext DortmunderGang = new GangContext();
            DortmunderGang.Name = "Dortmunder Gang";
            Pirat leChuck = new Pirat();
            leChuck.Name = "LeChuck";
            leChuck.Auswahlen(DortmunderGang);
            Console.WriteLine($"Gang {DortmunderGang.Name} hat der Id {DortmunderGang.GangContextId}");
            DortmunderGang.ListPirat();
            
            GangContext gang2 = DortmunderGang.AddAnotherGang();
            Console.WriteLine(gang2.GangContextId);

            //Aggregation
            for(int i =1; i<10; i++)
            {
                Pirat rPirat = new Pirat();
                DortmunderGang.AddPirat(rPirat);
                Console.WriteLine($" ID: {rPirat.PirateID} Name: {rPirat.PirateID} Name Gang: {DortmunderGang.Name}. ");
            }
            //Komposition
            for (int i = 3; i < 10; i++)
            {
                gang2.AddAnotherPirat();
            }           

            Console.Read();
        }
    }
}
