using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHRS_Rechner
{
    class Rechner
    {
        
        
        static private int dwert = 8;
        static private int awert = dwert / 11;
        static private int hwert = awert / 5;
        static private int rwert = 9 * hwert + 7 * awert;
        static private int swert = hwert / 11;

        static public void EuroZuDAHRS(double betrag)
        {
            int d = (int)(betrag / dwert);
            betrag %= dwert;
            int a = (int)(betrag / awert);
            betrag %= awert;
            int h = (int)(betrag / hwert);
            betrag %= hwert;
            int r = (int)(betrag / rwert);
            betrag %= rwert;
            int s = (int)(betrag / swert);
            Console.WriteLine("Der Betrag ist :{0} Dorsch, {1} Aal, {2} Hering, {3} Rochen, {4} Sprotten",d, a, h, r,s);
        }

        static public void ZSKZuEuro(int kuh, int schaf, int zeige, int klein_zeige)
        {
            double betrag;
            betrag = kuh * kuh_prise + schaf * schaf_prise + zeige * zeige_prise + klein_zeige * klein_zeige_prise;
            Console.WriteLine(betrag);
        }
    }

}
}
