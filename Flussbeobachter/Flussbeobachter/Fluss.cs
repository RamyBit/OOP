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
                        Console.WriteLine("Schiffe anhalten!!!");
                    }
                    else
                    {
                        Console.WriteLine("Es ist ok für Schiffe");
                    }
                }
                else if (typeof(Stadt).Equals(e.GetType()))
                {
                    if (this.Wasserstand > 8200)
                    {
                        Console.WriteLine("Städte haben die Wasserschutzwand errichten!!!");
                    }
                    else
                    {
                        Console.WriteLine("Es ist ok für Städte");
                    }
                }
                if (typeof(Klaerwerk).Equals(e.GetType()))
                {
                    if (this.Wasserstand > 8000)
                    {
                        Console.WriteLine("Die Einleitung der Klärwerke stoppen!!!");
                    }
                    else if (this.Wasserstand < 3000)
                    {
                        Console.WriteLine("Die Einlaitung der Klärwerke steigern");
                    }
                    else
                    {
                        Console.WriteLine("Es ist ok für Klärwerke");
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
