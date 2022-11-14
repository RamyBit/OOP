using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom
{
    class Allesfresser : Tier, IAllesfresser
    {
        public void Gemischtfutter()
        {
            Tier tier = new Tier();
            Console.WriteLine("Geben Sie Tier name ein");
            string name = Console.ReadLine();
            tier.SetName(name);
            Console.WriteLine("Wie viel Tiere?");
            int zahl = Convert.ToInt32( Console.ReadLine());
            tier.SetZahlen(zahl);
            Console.WriteLine("Geben Sie fütter Menge ein");
            double menge = Convert.ToDouble(Console.ReadLine());
            tier.SetFutterMenge(menge);
            Console.WriteLine(tier.GetName());
        }
    }
}
