using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Boerse
{
    static class AktuelleKursNotierungen
    {
        public static void GetTagesaktuellen(this List<Aktie> aktien)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(aktien[i].Tagesaktuellen); 
            }
            
        }

        public static void Ankaufen(this Aktie aktie, Boersianer boersianer)
        {
            boersianer.AddAktie(aktie);
            boersianer.Kapital += aktie.Wert;
        }
    }
}
