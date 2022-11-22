using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITOverride
{
    class Fisi : Fachinformatiker
    {
        public override void lernen()
        {
            base.lernen();
            Console.WriteLine("und ich lerene wie Fisi.");
        }
        public override void SpassHaben()
        {
            Console.WriteLine("Fiea hat Spaß bei Lernen");
        }
    }
}
