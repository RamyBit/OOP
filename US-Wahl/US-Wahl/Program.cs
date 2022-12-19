using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US_Wahl.Model;

namespace US_Wahl
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Person> whalvolk= new List<Person>();
            whalvolk=ModelGen.ZeigeWahlvolk();
            foreach (Person person in whalvolk)
            {
                Console.WriteLine($"ID:{person.ID}\n" +
                    $"Nachname: {person.Nachname}\n" +
                    $"Vorname: {person.Vorname}\n" +
                    $"Geschlacht: {person.Geschlecht}\n" +
                    $"Alter: {person.Alter} \n" +
                    $"PLZ: {person.PLZ} \n" +
                    $"========================================\n");
            }

            Console.ReadLine();
        }
    }
}
