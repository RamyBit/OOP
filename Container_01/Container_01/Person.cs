using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_01
{
    class Person
    {
        private string name;
        public void SetName(string s)
        {
            name = s;
        }
        public string GetName()
        {
            return name;
        }
    }
}
