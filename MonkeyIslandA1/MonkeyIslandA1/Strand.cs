using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIslandA1
{
    class Strand: Lokation
    {
        private string strandName;

        public Strand(string name): base(name)
        {
            this.strandName = name;
        }

        public string GetName()
        {
            return this.strandName;
        }
    }
}
