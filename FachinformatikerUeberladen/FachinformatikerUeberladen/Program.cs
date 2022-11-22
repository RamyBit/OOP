using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UeberschreibenVonMethodenUndInterfaces {
    class Program {
        static void Main ( string [ ] args ) {
            Fachinformatiker christian = new Fachinformatiker ( );
            Fiae ali = new Fiae ( );
            Fisi manni = new Fisi ( );

            // das dynamische Objekt (zur Laufzeit)ist NUN ein Fiae
            Fachinformatiker einEntwickler = new Fiae ( );

            // das dynamische Objekt ist NUN ein Fisi
            Fachinformatiker einFisi = new Fisi ( );

            Console.WriteLine ( "Einsatz virtueller Methoden");
            Console.WriteLine ( "bei Vererbung und identischer Methoden-Signatur!");

            //christian.Lernen ( ); 
            //ali.Lernen();
            //manni.Lernen ( );
            // explizit Konvertieren
            //(  (Fiae) einEntwickler).Lernen ( );

            //((Fisi) einFisi).Lernen ( );

            // Einsatz von virtuellen Methoden
            // mit und ohne override-Schlüsselwort
            //Console.WriteLine ( "virtuelle Methoden:" );

            //christian.NeuLernen ( ); // virtuelle Methode aus Basisklasse
            //einEntwickler.Lernen ( ); // nicht virtuelle Methode zum Vergleich !
            //einEntwickler.NeuLernen ( ); // virtuell und override
            //einFisi.NeuLernen ( ); // virtuell OHNE override
            //Console.WriteLine ( "=============================================");

            Console.WriteLine ( "interfaces und heterogene Container" );
            Console.WriteLine ( "Automatische Wahl der speziellsten Methode - durch virtuelle Methoden" );
            // Container mit IEnjoyAble-Typ
            IEnjoyAble [ ] einContainer = new IEnjoyAble [ 5 ];
            einContainer [ 0 ] = new Fisi ( );
            einContainer [ 1 ] = new Fiae ( );
            einContainer [ 2 ] = new Fiae ( );
            einContainer [ 3 ] = new Fachinformatiker ( );
            einContainer [ 4 ] = new Fisi ( );

            foreach ( var einWertAusDemArray in einContainer ) {
                Console.WriteLine ( einWertAusDemArray );
            }
            Console.WriteLine ( "____________________________" );

            foreach ( var einWertAusDemArray in einContainer ) {
                einWertAusDemArray.SpassHaben ( );
            }

            Console.Read ( );
        }
    }
}
