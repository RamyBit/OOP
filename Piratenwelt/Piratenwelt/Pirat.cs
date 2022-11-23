using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenwelt
{
    class Pirat
    {
        public int PirateID { get; set; }
        public string Name { get; set; }
        public int GangId { get; set; }

      
        public void Auswahlen(GangContext gang)
        {
            if (GangId == gang.GangContextId)
            {
                Console.WriteLine("Pirat {0} gehört schon der Gang {1} hat der ID {2} .",this.Name, gang.Name, gang.GangContextId);
            }
            else
            {
                gang.AddPirat(this);
            }
        }
    }
}
