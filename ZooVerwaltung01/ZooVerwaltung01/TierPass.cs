using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class TierPass
    {
       
        public int PassNr { get; set; }
        public string TierName { get; set; }
        public string FuetterArt { get; set; }
        public double FutterMenge { get; set; }
        public string GZustand { get; set; }
        public string FZustand { get; set; }

        public TierPass()
        {
            PassNr = 0;
        }
        
    }
}
