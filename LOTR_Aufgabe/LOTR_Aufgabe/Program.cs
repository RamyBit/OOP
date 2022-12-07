using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTR_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Finger frodosFinger = new Finger();
            frodosFinger.Name = "Frodo";
            frodosFinger.HatDerRing = true;
            frodosFinger.FingerCheck += frodosFinger.OnRingAufstecken;
            frodosFinger.RingAufstecken();
            Console.ReadKey();
            
        }
    }
}
