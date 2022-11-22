using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Months months = new Months();
            foreach (string temp in months.GetList())
                Console.WriteLine(temp);
            Console.ReadLine();
        }
        public class Months 
        {
            string[] month = { "Januar", "Februar", "März", "April",
                                "Mai", "Juni", "Juli", "August", "September",
                                "Oktober", "November", "Dezember"
                                };

            public IEnumerable GetList()
            {
                for (int i = 0; i < month.Length; i++)
                {
                    yield return month[i];
                }
            }
        }

    }
}
