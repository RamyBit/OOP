using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    class Tier: IBerechtigung
    {
        public string Tierart { get; set; }
        public IVerantwortlicher verantwortlicher { get; set; }
        public Arche Zufluchtsort { get; set; }
        public void Eintreten(Arche arche)
        {
            Zufluchtsort = arche;
        }
        public string ZeigeInfo()
        {
            return this.Tierart;
        }
    }
}
