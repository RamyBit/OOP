using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    class Kneipe : Lokation
    {
        private string kneipeName;

        public Kneipe(string name) : base(name)
        {
            this.kneipeName = name;
        }

        public string GetName()
        {
            return this.kneipeName;
        }
    }
}
