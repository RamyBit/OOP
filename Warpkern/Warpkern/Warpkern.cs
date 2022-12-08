using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warpkern
{
    class Warpkern
    {
        public int WarpkernTemp { get; set; }
        public event EventHandler<Temp> TempMesser;

        public void TempAendern()
        {
            int alteTemp = WarpkernTemp;
            Console.WriteLine("Geben Sie die neue Temperatur ein :");
            WarpkernTemp = Convert.ToInt32(Console.ReadLine());
            int aktuellTemp = WarpkernTemp;
            TempMesser(this, new Temp() { AlteTemp = alteTemp, NeueTemp = aktuellTemp });
            


        }

        public virtual void OnTempAendern(object sender, Temp e)
        {
            if (sender != null)
            {
                Console.WriteLine("Die alter Warpkern Temperatur {0}, neue Temperatur {1}   Uhrzeit {2} ",e.AlteTemp,e.NeueTemp,e.AktuellUhrzeit);
            }
        }
        public virtual void OnGefaerTemp(object sender, Temp e)
        {
            if (sender != null)
            {
                if (e.NeueTemp < 500)
                {
                    Console.WriteLine("Temperatur in Ordnung Herr Kapitan");
                }
                else
                {
                    Console.WriteLine("Gefähr Gefähr WarpKern fast Implorirt");
                }
                
            }
        }
    }
}
