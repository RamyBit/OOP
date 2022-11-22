using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeberschreibenVonMethodenUndInterfaces {
    class Fisi : Fachinformatiker {
        public void Lernen ( ) {
            Console.WriteLine ( "ich lerne wie ein FISI" );
        }

        public void NeuLernen ( ) {
            Console.WriteLine ( "ich lerne NUR MIT OVERRIDE wie ein dynamischer FISI" );
        }

        public override void SpassHaben ( ) {
            Console.WriteLine ( " Spaß FISI !!!" );
        }
    }
}
