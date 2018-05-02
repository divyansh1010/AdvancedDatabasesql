using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Van : Engine
    {
        public sealed override double cylinders { get; set; }

        public sealed override int MaxHorsePower()
        {
            return 230;
        }
    }
}
