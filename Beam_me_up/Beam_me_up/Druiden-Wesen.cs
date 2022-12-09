using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beam_me_up
{
    class Druiden_Wesen: Wesen_Objekt
    {
        public Druiden_Wesen()
        {
            Random random = new Random();
            int nummer = random.Next(1,999);
            this.Name = "R2D" + nummer.ToString("000");
        }
    }
}
