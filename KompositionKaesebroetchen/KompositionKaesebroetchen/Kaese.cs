using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionKaesebroetchen
{
    class Kaese
    {
        private string bezeichnung;

        public Kaese(string bez)
        {
            this.bezeichnung = bez;
        }
        public string GetBezeichnung()
        {
            return bezeichnung;
        }
    }
}
