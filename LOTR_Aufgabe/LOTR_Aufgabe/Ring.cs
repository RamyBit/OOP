using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTR_Aufgabe
{
    class Ring
    {
        public event EventHandler<EventArgs> RingCheck;

        public void RingWerfen()
        {
            RingCheck(this, new EventArgs());
        }
        public virtual void OnRingInLava(object sender, EventArgs e)
        {
            Console.WriteLine("Ring wird recyclen bis zum Nächste Lord von Mordor erneu zu bauen");
        }
    }
}
