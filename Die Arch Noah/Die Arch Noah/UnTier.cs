using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    class UnTier : IBerechtigung
    {
        public string Name { get; set; }
        public IVerantwortlicher verantwortlicher { get; set; }
        public void FahrscheinZeigen(IVerantwortlicher verantwortlicher)
        {
            this.verantwortlicher = verantwortlicher;
        }
        public void Eintreten(Arche arche)
        {
            
        }
        public string ZeigeInfo()
        {
            return (this.Name);
        }
    }
}
