using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boerse
{
    class Program
    {
        static void Main(string[] args)
        {
            Aktie aktie1 = new Aktie();
            aktie1.Wert = 100m;
            aktie1.Name = "Tsla";
            aktie1.Tagesaktuellen = 111m;
            Aktie aktie2 = new Aktie();
            aktie2.Name = "MST";
            aktie2.Wert = 200m;
            aktie2.Tagesaktuellen = 222m;
            List<Aktie> aktien = new List<Aktie>();
            aktien.Add(aktie1);
            aktien.Add(aktie2);

            aktien.GetTagesaktuellen();
            Boersianer boersianer1 = new Boersianer();
            aktie1.Ankaufen(boersianer1);
             
            Console.ReadLine();
        }
    }
}
