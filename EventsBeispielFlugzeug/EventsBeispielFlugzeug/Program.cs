using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBeispielFlugzeug
{
    class Program
    {
        static void Main(string[] args)
        {
            Flugzeug flugzeug = new Flugzeug();
            flugzeug.OelDruckMesser += flugzeug.OnEventEintritt;
            flugzeug.FliegHerum();
            Console.ReadKey();
        }
    }
}
