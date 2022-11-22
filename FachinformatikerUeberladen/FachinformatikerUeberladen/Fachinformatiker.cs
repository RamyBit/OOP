using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeberschreibenVonMethodenUndInterfaces {
    class Fachinformatiker : IEnjoyAble {
        public void Lernen ( ) {
            Console.WriteLine ( "ich lerne wie ein Fachinformatiker");
        }

        public virtual void NeuLernen ( ) {
            Console.WriteLine ( "ich lerne wie ein virtueller Fachinformatiker" );
        }

        // wg. interface 
        public virtual void SpassHaben ( ) {
            Console.WriteLine ( "Fachinformatiker Spaß");
        }
    }
}
