using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warpkern
{
    class Temp : EventArgs
    {
        public int AlteTemp { get; set; }
        public int NeueTemp { get; set; }
        public string AktuellUhrzeit { get; set; } = DateTime.Now.ToString();
    }
}
