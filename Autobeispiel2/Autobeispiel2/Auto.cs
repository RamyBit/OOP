using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobeispiel2
{
    class Auto
    {
        private Person fahrer;
        private string name;
        private bool zustand;

        public void EinsteigenPerson(Person person)
        {
            fahrer = person;
        }

        public Person WerIstDerFahrer()
        {
            return fahrer;
        }

        public void SetName (string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public void SetZustand(bool z)
        {
            zustand = z;
        }
        public bool GetZustand()
        {
            return zustand;
        }
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
        public static void Ausgeben()
        {
            Console.WriteLine("Warum geht der Zugriff auf name und zustand nicht?");
        }

    }
}
