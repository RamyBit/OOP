﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    interface IVerantwortlicher
    {
        bool BerechtigungPruefen(IBerechtigung berechtigter);
    }
}