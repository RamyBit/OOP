using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompositionKaesebroetchen
{
    class Butter
    {
        private string bezeichnung;

        public Butter(string bez)
        {
            this.bezeichnung = bez;
        }
        public string GetBezeichnung()
        {
            return bezeichnung;
        }
    }
}
