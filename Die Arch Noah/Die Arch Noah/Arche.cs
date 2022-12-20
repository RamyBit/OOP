using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    class Arche
    {
        private List<IBerechtigung> passagiere = new List<IBerechtigung>();
        public void AddMitreisenen(IBerechtigung berechtigter)
        {
            passagiere.Add(berechtigter);
        }
    }
}
