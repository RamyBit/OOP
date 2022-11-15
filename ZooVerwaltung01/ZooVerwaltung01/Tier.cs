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
        public string FZustand { get; set; }
        public TierPass tierPass { get; set; }
        public Futter futter { get; set; }
        public Tier(string name ,Untersuchung u,Fuetterung f, Futter futter, Mitarbeiter m)
        {
            Name = name;
            TierPass tPass = new TierPass();
            tPass.PassNr = u.ID;
            tPass.TierName = Name;
            GetUntersucht(u, m);
            tPass.GZustand = this.GZustand;
            GetFuttert(f, this, m,futter);
            tPass.FZustand = this.FZustand;
            tPass.FuetterArt = futter.Art;
            tPass.FutterMenge = futter.Menge;
            tierPass = tPass;

        }
        public void GetUntersucht(Untersuchung u, Mitarbeiter mitarbeiter)
        {
             u.GetUntersucht(this, mitarbeiter);
        }
        public void GetFuttert(Fuetterung fuetterung,Tier tier, Mitarbeiter mitarbeiter, Futter futter)
        {
            fuetterung.Getfuetert(tier,mitarbeiter,futter);
        }
        public TierPass GetTierPass()
        {
            return this.tierPass;
        }
        public void SetFutter(Futter futter)
        {
            this.futter = futter;
        }

    }
}
