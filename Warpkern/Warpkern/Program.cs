using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warpkern
{
    class Program
    {
        static void Main(string[] args)
        {
            Warpkern warpkern = new Warpkern();
            warpkern.TempMesser += warpkern.OnTempAendern;
            warpkern.TempMesser += warpkern.OnGefaerTemp;
            while (true)
            {
                warpkern.TempAendern();
            }
            
        }
    }
}
