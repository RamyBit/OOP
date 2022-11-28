using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Flaschen
{
    class Program
    {
        static void Main(string[] args)
        {
            Flasche<Getraenk> flasche = new Flasche<Getraenk>();
            flasche.Fuellen(new Bier { Name = "Corona" , Brauerei = "Coronita Cerveza" }) ;
            flasche.Fuellen(new Rotwein { Name = "Chateau", Herkunft = "Frankreich" });
            
            if (flasche.IstLeer()) { 
                Console.WriteLine("Flasche ist leer"); 
            }
            else { Console.WriteLine("Flasche ist nicht leer"); 
            }

            List<Getraenk> getraenken = new List<Getraenk>();
            flasche.Leeren(out getraenken);
            foreach (var item in getraenken)
            {
                Console.WriteLine(item.Name);
            }
            Console.Read();
        }
    }
}
