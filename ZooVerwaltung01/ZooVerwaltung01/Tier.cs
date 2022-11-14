using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Tier
    {
        public string Name { get; set; }
        public Tier()
        {
            TierPass tPass = new TierPass();
            tPass.PassNr += 1;
            tPass.TierName = Name;
            tPass.Gzustand = Untersuchung.GZustand;

        }

        
    }
}
