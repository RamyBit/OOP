using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Fuetterung
    {
        public void DurchFuehren(Tier tier, Mitarbeiter mitarbeiter, Futter f)
        {
            Console.WriteLine(" {1} wird von {2} gefütert",  tier.Name, mitarbeiter.Name);
            Console.WriteLine("Geben Sie die fütterart von {0} ein: ", tier.Name);
            f.Art = Console.ReadLine();
            Console.WriteLine("Geben Sie füttermenge ein :");
            f.Menge = Convert.ToDouble( Console.ReadLine());
        }
        public void Getfuetert(Tier t)
        {
            t.GetFueter = this.GZustand;

        }
    }
}
