using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacherThread
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart del = new ThreadStart(DoSomthing)
        }

        public static void DoSomthing()
        {
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j <= 20 ; j++)
                {
                    Console.WriteLine("X");
                }
            }
        }
    }
}
