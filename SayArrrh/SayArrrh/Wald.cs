﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayArrrh
{
    [Serializable]
    class Wald : ILocable
    {
        public string Name { get; set; }
        public string GetName()
        {
            return this.Name;
        }
    }
}
