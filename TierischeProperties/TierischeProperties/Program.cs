using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierischeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(11);

            for (int i = 0; i <= 10; i++)
                myStack.Push(i * i);

            PrintStack(myStack);
            Console.ReadLine();
        }

        private static void PrintStack(Stack stack)
        {
            while(stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
            throw new NotImplementedException();
        }
    }
}
