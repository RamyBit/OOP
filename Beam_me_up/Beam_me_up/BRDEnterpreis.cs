using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beam_me_up
{
    class BRDEnterpreis
    {
        List<Wesen_Objekt> Bord = new List<Wesen_Objekt>();
        public int Geschwindigkeit { get; set; }
        public event EventHandler<Beam> Beamer;

        public void Beaming(Wesen_Objekt wesen_objekt)
        {
            
            Beamer(this, new Beam {BeamedObjekts = wesen_objekt });
        }

        public virtual void OnBeaming(object sender, Beam e)
        {
            if (sender != null)
            {
                Console.WriteLine($"Versuchen {e.BeamedObjekts.Name} up zu beamen.");
               // Console.WriteLine(typeof(Druiden_Wesen).Equals( e.BeamedObjekts.GetType()));
                if (this.Geschwindigkeit<1000)
                {
                    if (typeof(Druiden_Wesen).Equals((e.BeamedObjekts.GetType())))
                    {
                        Console.WriteLine($"{e.BeamedObjekts.Name} wird von BRDEnterpreis Up Gebeamt!!!");
                        Bord.Add(e.BeamedObjekts);
                    }
                    else
                    {
                        Console.WriteLine($"{e.BeamedObjekts.Name} konnte nicht Up Gebeamt wird !!!");
                    }

                }
                else if (this.Geschwindigkeit>1000 && this.Geschwindigkeit<1200)
                {
                    if (typeof(Mutant_xxx).Equals ((e.BeamedObjekts.GetType())))
                    {
                        Console.WriteLine($"{e.BeamedObjekts.Name} wird von BRDEnterpreis Up Gebeamt!!!");
                        Bord.Add(e.BeamedObjekts);
                    }
                    else
                    {
                        Console.WriteLine($"{e.BeamedObjekts.Name} konnte nicht Up Gebeamt wird !!!");
                    }
                }
                else if (this.Geschwindigkeit > 3000)
                {
                    if (typeof(Wookie).Equals (e.BeamedObjekts.GetType()))
                    {
                        Console.WriteLine($"{e.BeamedObjekts.Name} wird von BRDEnterpreis Up Gebeamt!!!");
                        Bord.Add(e.BeamedObjekts);
                    }
                    else
                    {
                        Console.WriteLine($"{e.BeamedObjekts.Name} konnte nicht Up Gebeamt wird !!!");
                    }
                }
               
            }
        }

        public void WerIstAnBord()
        {
            Console.WriteLine("Die Folgende Wesen-Objekte sind an Bord");
            foreach (var item in Bord)
            {
                Console.WriteLine("  - "+ item.Name);
            }
        }
    }
}
