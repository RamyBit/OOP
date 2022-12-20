using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Arch_Noah
{
    interface IBerechtigung
    {
        void Eintreten(Arche arche);
        string ZeigeInfo();
    }
}
