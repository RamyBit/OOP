using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Datentyp
{
    class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter,
            Karneval
        }
        enum Schulnoten
        {
            SEHRGUT,
            GUT,
            BEFREIEDIGNED,
            AUSTEICHEND,
            MANGELHAFT,
            UNGENUEGEND
        }
        enum Farben
        {
            ROT,
            BLUE,
            GRUEN
        }
        static void Main(string[] args)
        {
            Season jahreszeit = Season.Karneval;
            Season winter = Season.Winter;
            Schulnoten schulnoten= Schulnoten.GUT;
            Farben farben = Farben.GRUEN;
            var zahl = (Season)4;
            Console.WriteLine(zahl);
            int zahlfuerWinter = (int)winter;
            Console.WriteLine( zahlfuerWinter);


            Console.ReadKey();


        }
    }
}
