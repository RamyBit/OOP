using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayArrrh
{
    [Serializable]
    class Pirat
    {
        public string Name { get; set; }
        public string Aufenhaktsort { get; set; }
        public void Bewegen(ILocable pos)
        {
            this.Aufenhaktsort = pos.GetName();
        }
        public Pirat(Insel insel)
        {
            insel.AddPirat(this);
        }
    }
}
