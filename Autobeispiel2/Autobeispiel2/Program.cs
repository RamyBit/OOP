using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobeispiel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto meins = new Auto();
            meins.SetName("das ist meins");
            Console.WriteLine(meins.GetName());
            meins.SetZustand(false);
            meins.StartStop();
            Console.WriteLine(meins.GetZustand());

            Auto.Ausgeben();
          

            Person person1 = new Person();
            person1.SetName("George");
            Console.WriteLine(person1.GetName());
            meins.EinsteigenPerson(person1);
            Console.WriteLine(meins.WerIstDerFahrer().GetName());
            Console.Read();
        }
    }
}
