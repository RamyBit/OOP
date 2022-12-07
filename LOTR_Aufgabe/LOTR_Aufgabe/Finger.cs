using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTR_Aufgabe
{
    enum Sichtbar
    {
        SICHTBAR,
        UNSICHTBAR
    }
    class Finger
    {
        private Sichtbar sichtbar = Sichtbar.SICHTBAR;
        public string Name { get; set; }
        public bool HatDerRing { get; set; }
        public event EventHandler<EventArgs> FingerCheck;
        
        
        public void RingAufstecken()
        {
            if (HatDerRing)
            {
                FingerCheck(this, new EventArgs());
            }
            else
            {
                Console.WriteLine($"{Name} hat keine Ring ");
            }
        }

        public virtual void OnRingAufstecken(object sender, EventArgs e)
        {
            if (sender != null)
            {
                this.sichtbar = Sichtbar.UNSICHTBAR;
                Console.WriteLine($"{Name} ist {sichtbar.ToString()}");
            }
        }
    }
}
