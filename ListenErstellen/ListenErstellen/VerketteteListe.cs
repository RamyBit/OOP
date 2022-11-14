using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenErstellen
{
    class VerketteteListe
    {
        private Knoten erstes, akt, neu, letztes;

        public void Add(int zahl)
        {
            neu = new Knoten(zahl);
            erstes = neu;
            
        }
    }
}
