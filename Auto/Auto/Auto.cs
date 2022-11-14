using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobeispiel
{
    class Auto
    {
        // fields
        private string name;
        private bool zustand;

        // constructor

        //static methodes
        public static void Ausgeben()
        {
            Console.WriteLine("Warum geht der Zugriff auf name und zustand nicht?");
        }
        // methods
        public void StartStop()
        {
            if (zustand)
            {
                zustand = false;
            }
            else
            {
                zustand = true;
            }
                       
        }
        public bool GetZustand()
        {
            return zustand;
        }
    }
}
