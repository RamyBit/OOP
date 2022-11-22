using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITOverride
{
    class Fachinformatiker : IEnjoyAble
    {
        
        public virtual void lernen()
        {
            Console.WriteLine("Ich lerne wie Informatiker");
        }

        public virtual void SpassHaben() 
        {
            Console.WriteLine("Fachinformatiker hat Spaß bei Lernen.");
        }
    }
}
