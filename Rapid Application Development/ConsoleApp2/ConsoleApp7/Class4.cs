using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Car : Engine
    {
        public override double cylinders { get; set; }

        public override int MaxHorsePower()
        {
            return 230;
        }

        public Car() { }

        public Car(double cylinders)
        {

            this.cylinders = cylinders;

        }

        public override string ToString()
        {
            return string.Format("This Car has {0} cynlinders", cylinders);
        }

    }
}
