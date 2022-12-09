using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flussbeobachter
{
    class Fluss 
    {
        public string Name { get; set; }
        public int Wasserstand { get; set; }

        public event EventHandler<Beobachter> WasserStandMesser;

        public virtual void OnWasserstandAendern(object sender, Beobachter e)
        {
            if (sender != null)
            {
                if (typeof(Schiff).Equals(e.GetType()))
                {
                    if (this.Wasserstand < 250 || this.Wasserstand > 8000)
                    {
                        Console.WriteLine("Die Schiff {0} anhalten!!!",e.Name);
                    }
                    else
                    {
                        Console.WriteLine("Es ist ok für die Schiffe {0} ", e.Name);
                    }
                }
                else if (typeof(Stadt).Equals(e.GetType()))
                {
                    if (this.Wasserstand > 8200)
                    {
                        Console.WriteLine("Stadt {0} haben die Wasserschutzwand errichten!!!",e.Name);
                    }
                    else
                    {
                        Console.WriteLine("Es ist ok für Stadt {0}", e.Name);
                    }
                }
                if (typeof(Klaerwerk).Equals(e.GetType()))
                {
                    if (this.Wasserstand > 8000)
                    {
                        Console.WriteLine("Die Einleitung der Klärwerk {0} stoppen!!!",e.Name);
                    }
                    else if (this.Wasserstand < 3000)
                    {
                        Console.WriteLine("Die Einlaitung der Klärwerk {0} steigern", e.Name);
                    }
                    else
                    {
                        Console.WriteLine("Es ist ok für Klärwerk {0}", e.Name);
                    }
                }
            }
        }
        public void WasserstandAendern(Beobachter beobachter)
        {
            Console.WriteLine($"Geben Sie {this.Name} Wasserstand wert:");
            this.Wasserstand = Convert.ToInt32(Console.ReadLine());
            WasserStandMesser(this, beobachter);
        }
    }
}
