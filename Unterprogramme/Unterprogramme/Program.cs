using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterprogramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.MachWas();
            Console.WriteLine(Program.MachWasUndGibWas());
            Console.WriteLine(Program.FunktionMitParameter(1000));
            Console.WriteLine(Program.FunktionMit2Parameter(10, 4));
            Console.Read();
        } //Ende Hauptprogramm

        static string MachWasUndGibWas()
        {
            return ("Hallo aus der Funktion");
        }
        static void MachWas()
        {
            Console.WriteLine("Ich wurde gerufen");
        }
       
        static int FunktionMitParameter(int para_01)
        {

            return para_01 * 2;
        }
        static int FunktionMit2Parameter(int para_01, int para_02)
        {
            int eineVariable = 333;
            return para_01 * para_02 + 1 + eineVariable;
        }
    }
}
