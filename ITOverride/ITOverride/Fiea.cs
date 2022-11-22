using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITOverride
{
    class Fiea : Fachinformatiker
    {
        public override void  lernen()
        {
            Console.WriteLine("Ich leren wi FIEA");
        }
        public override void SpassHaben()
        {
            Console.WriteLine("Fiea hat Spaß bei Lernen");
        }
    }
}
