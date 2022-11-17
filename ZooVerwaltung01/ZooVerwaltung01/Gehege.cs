using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Gehege
    {
        private List<Tier> tiere = new List<Tier>();

        public void AddTier(Tier tier)
        {
            tiere.Add(tier);
        }
    }
}
