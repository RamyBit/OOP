using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    class Mensch : IBerechtigung
    {
        public string Name { get; set; }
        public void Eintreten(Arche arche)
        {
            if (Name == "Hanni" || Name == "Nanni" || Name=="Fliwatüt" || Name == "Donald" || Name == "Der Imperator" )
            {
                Console.WriteLine("Kann nicht eingetreten werden");
            }
            else
            {
                arche.AddMitreisenen(this);
            }
        }
        public string ZeigeInfo()
        {
            return(this.Name);
        }
    }
}
