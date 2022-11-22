using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeberschreibenVonMethodenUndInterfaces {
    class Fiae : Fachinformatiker{
        public void Lernen ( ) {
            Console.WriteLine ( "ich lerne wie ein FIAE" );
        }

        public override void NeuLernen ( ) {
            Console.WriteLine ( "ich lerne wie ein dynamischer FIAE" );
        }

        public override void SpassHaben ( ) {
            Console.WriteLine ( "Programmierer Spaß" );
        }
    }
}
