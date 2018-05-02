using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class CompactCar : Car
    {
        public CompactCar() { }

        public sealed override double cylinders
        {
            get
            {
                return base.cylinders;
            }

            set
            {
                base.cylinders = value;
            }
        }

    }


    class MidSized : CompactCar
    {

        public MidSized() { }


    }

}
