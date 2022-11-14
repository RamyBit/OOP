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
        public string FutterMenge { get; set; }
        public string Gzustand { get; set; }
        
        public TierPass()
        {
            PassNr = 0;
        }
    }
}
