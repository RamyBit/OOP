using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionKaesebroetchen
{
    class Ei
    {
        private string bezeichnung;

        public Ei(string bez)
        {
            this.bezeichnung = bez;
        }
        public string GetBezeichnung()
        {
            return bezeichnung;
        }
    }
}
