using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Untersuchung
    {
        public int ID { get; set; }
        public string GZustand { get; set; }

        public void DurchFuehren(Tier tier, Mitarbeiter mitarbeiter)
        {
            Console.WriteLine("Operation nr.{0} {1} wird von {2} untersucht",ID,tier.Name,mitarbeiter.Name);
            Console.WriteLine("Geben Sie die Gesundheitstand von {0} ein: ", tier.Name);
            tier.GZustand = Console.ReadLine();
        }
        public void GetUntersucht(Tier t, Mitarbeiter m)
        {
            this.DurchFuehren(t, m);
            t.GZustand=this.GZustand;
            
        }
    }
}
