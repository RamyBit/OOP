using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooVerwaltung01
{
    class Tier
    {
        public string Name { get; set; }
        public string GZustand { get; set; }
        public Tier()
        {
            TierPass tPass = new TierPass();
            tPass.PassNr += 1;
            tPass.TierName = Name;
            //[tofix] Assozition
            Untersuchung u = new Untersuchung();
            GetUntersucht(u);
            tPass.Gzustand = this.GZustand;
            Fuetterung f = new Fuetterung(this)

        }
        public void GetUntersucht(Untersuchung u, Mitarbeiter mitarbeiter)
        {
            u.DurchFuehren(this, mitarbeiter);
             u.GetUntersucht(this);
        }
        public void GetFuttert(Fuetterung f)
        {
            f.DurchFuehren();
        }
        
    }
}
