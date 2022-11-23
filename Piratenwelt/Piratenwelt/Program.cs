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
            GangContext DortmunderGang = new GangContext();
            DortmunderGang.Name = "Dortmunder Gang";
            Pirat leChuck = new Pirat();
            leChuck.Name = "LeChuck";
            leChuck.Auswahlen(DortmunderGang);
            Console.WriteLine($"Gang {DortmunderGang.Name} hat der Id {DortmunderGang.GangContextId}");
            DortmunderGang.ListPirat();
            Console.Read();
        }
    }
}
