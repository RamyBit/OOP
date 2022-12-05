using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace PiratesCoveLine
{
    class Bus 
    {
        public Queue<Golfer> Golfers { get; set; } = new Queue<Golfer>();
        public bool Tuerklemmt { get; set; } = false;
        public int MaxPlatze { get; set; } = 4; // nur 4 Weil die andere Platze sin bei ZSK Wahrungen beligt, um der ausflug zu bezahlen
        public string AktuelleStation { get; set; }
        public string NaexteStation { get; set; }
        public int Pos { get; set; } = 1;
        public double Geschwendigkeit { get; set; } = 0.009;
        public bool BusHalten { get; set; }
        public double Zeit { get; set; } // zeit bis nächste haltstelle

        public void eineAusteigen()
        {
            Golfers.Dequeue();
        }
        public void eineEinsteigen(Golfer golfer)
        {
            Golfers.Enqueue(golfer);
        }
        public void fahren (int ausfahrt , int einkunft, Karte karte)
        {
            double distanz = einkunft - ausfahrt;
            if (einkunft != ausfahrt)
            {
                Zeit = distanz/Geschwendigkeit;
               
            }
            for (int pos = ausfahrt; pos <= einkunft; pos++)
            {
                Pos = pos;
                AktuelleStation = karte.GetStation(Pos);
                Thread.Sleep((int)Zeit);
            }

        }

        public void einsteigen (Queue<Golfer> einGolfers)
        {
            while (einGolfers.Count > 0 && !istVoll())
            {
                if (!Tuerklemmt)
                {
                    Golfers.Enqueue(einGolfers.Dequeue());
                }
                else
                {
                    einGolfers.Enqueue(einGolfers.Dequeue());
                }
            }
                         
           
        }

        public Queue<Golfer> aussteigen()
        {
            Queue<Golfer> ausGolfers = new Queue<Golfer>();
            while (Golfers.Count > 0)
            {
                if (!Tuerklemmt)
                {
                    ausGolfers.Enqueue(Golfers.Dequeue());
                }
                else
                {
                    Golfers.Enqueue(Golfers.Dequeue());
                }
                
            }
            return ausGolfers;            
        }

        public bool istVoll()
        {
            if (Golfers.Count >= MaxPlatze)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
