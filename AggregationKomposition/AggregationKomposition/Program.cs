using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationKomposition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aggregation
            Person kim = new Person();
            Person lee = new Person();
            kim.SetName("Kim");
            lee.SetName("Lee");

            Person[] people = new Person[3];
            people[0] = kim;
            people[1] = kim;
            people[2] = lee;

            foreach (Person person in people)
            {
                Console.WriteLine(person.GetName());
            }
            people = null;
            //Console.WriteLine(people[0]);
            Console.WriteLine(kim.GetName());

            // Komposition 
            Person[] people2 = new Person[3];
            people2[0] = new Person();
            people2[1] = new Person();
            people2[2] = new Person();

            people2[0].SetName("Robert");
            people2[1].SetName("Sven");
            people2[2].SetName("Ali");

            for ( int i=0; i < people2.Length; i++)
            {
                Console.WriteLine(people2[i].GetName());
            }

            people2 = null;
            Console.WriteLine(people2[0].GetName());
            Console.Read();
        }
    }
}
