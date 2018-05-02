using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
        class Shirt : IButton
        {
            public double Shinniness { get; set; }
            public double Looseness { get; set; }
            private string color;

            int numStains = 0;
            int maxStains = 3;
            string[] stains;


            public string Color
            {

                set { color = value; }
                get { return color; }
            }
            public Shirt()
            {

                stains = new string[maxStains];
            }

            public bool SetStains(string theStain)
            {

                if (numStains < maxStains)
                {

                    stains[numStains] = theStain;
                    numStains++;

                    return true;
                }
                else
                {
                    return false;
                }

            }

            public Shirt(string color, double loosness, double shininess)
            {

                this.color = color;
                Looseness = loosness;
                Shinniness = shininess;
                stains = new string[maxStains];
            }

            public bool IsLoose()
            {

                if (Looseness < 10)
                    return true;

                return false;

            }

            public static bool operator !(Shirt one)
            {

                if ((one.Color == null || one.Color.Length == 0) && one.Shinniness == 0 && one.Looseness == 0)
                    return true;

                return false;
            }

            public static Shirt operator *(Shirt one, Shirt two)
            {

                Shirt multiplied = new Shirt();

                multiplied.Shinniness = one.Shinniness * two.Shinniness;

                multiplied.Looseness = one.Looseness * two.Looseness;

                if (multiplied.Looseness > 100)
                    multiplied.Looseness = 100;

                /*
                 * 
                */

                multiplied.color = one.Color + "-" + two.Color;

                return multiplied;
            }
            public override string ToString()
            {
                return String.Format("Color is {0}. Shinniness is {1}. Looseness is {2}", color, Shinniness, Looseness);
            }
        }
    }

}
}
