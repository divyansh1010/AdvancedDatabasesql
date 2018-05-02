using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    interface IButton
    {
        double Shinniness { get; set; }
        double Looseness { get; set; }
        bool IsLoose();

    }
}
