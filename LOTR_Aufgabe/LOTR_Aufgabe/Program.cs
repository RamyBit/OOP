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
            Ring ringThatRulesAll = new Ring();
            Finger frodosFinger = new Finger();
            frodosFinger.Name = "Frodo";
            frodosFinger.HatDerRing = true;
            ringThatRulesAll.RingCheck += ringThatRulesAll.OnRingInLava;
            frodosFinger.FingerCheck += frodosFinger.OnRingAufstecken;
            frodosFinger.RingAufstecken();
            ringThatRulesAll.RingWerfen();
            Console.ReadKey();
            
        }
    }
}
