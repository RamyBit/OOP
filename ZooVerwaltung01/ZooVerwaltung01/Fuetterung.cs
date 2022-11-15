using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Fuetterung
    {
        public string FZustand { get; set; }
        public void DurchFuehren(Tier tier, Mitarbeiter mitarbeiter, Futter f)
        {
            Console.WriteLine("{0} wird von {1} gefütert",  tier.Name, mitarbeiter.Name);
            Console.WriteLine("Geben Sie die fütterart von {0} ein: ", tier.Name);
            f.Art = Console.ReadLine();
            Console.WriteLine("Geben Sie füttermenge ein :");
            f.Menge = Convert.ToDouble( Console.ReadLine());
            tier.SetFutter(f);
            FZustand = "OK";
        }
        public void Getfuetert(Tier t, Mitarbeiter mitarbeiter, Futter f)
        {
            this.DurchFuehren(t, mitarbeiter, f);
            t.FZustand = this.FZustand;

        }
    }
}
