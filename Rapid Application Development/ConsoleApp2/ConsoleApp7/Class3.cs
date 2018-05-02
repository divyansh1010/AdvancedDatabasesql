using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Engine
    {
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public abstract double cylinders { get; set; }

        public abstract int MaxHorsePower();

        public int Wheels(int numWheels)
        {

            return 2 * numWheels;
        }

    }
}
