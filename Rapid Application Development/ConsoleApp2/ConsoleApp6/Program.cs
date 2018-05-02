using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApplication1_021518
    {

        public struct Bag
        {

            public int straps, zippers;

            public Bag(int Straps, int Zippers)
            {

                straps = Straps;
                zippers = Zippers;
            }

        }




        class Program
        {
            delegate void VoidDelegate();
            delegate string StringDelegate(string s);
            delegate int IntDelegate(int i);

            static void HouseRunner()
            {
                House house1 = new House();
                House house2 = new House(2);

                House house3 = new House(1, 5.4);

                House house3_1 = new House(rooms: 7, roof: 3);

                //house3_1.Rooms = 12.5;

                Console.WriteLine(house1.Floors);
                Console.WriteLine(house1.Rooms);

                Console.WriteLine("The house has {0} rooms, {1} floors and {2} roofs",
                    house3_1.Rooms, house3_1.Floors, house3_1.Roof);

                Console.WriteLine(house3_1.ToString());

                Console.WriteLine(house2.ToString());

            }

            static void StaticMethodVoid()
            {

                string s = "my string";
                s.ToUpper();

                Console.WriteLine("The is called from our StaticMethodVoid function");

            }

            //create a static method that:
            //takes an integer
            //returns double the value
            static int StaticMethodInt(int myInt)
            {

                return myInt * 2;
            }

            //create a static method that:
            //takes a string
            //returns that string in uppercase

            static string StaticMethodString(string myString)
            {

                return myString.ToUpper();
            }

            static void StructExample()
            {
                Bag b;

                Bag c = new Bag(4, 7);

                b.straps = 2;
                b.zippers = 3;

                Console.WriteLine("The bag has {0} straps and {1} zippers", b.straps, b.zippers);

                Console.WriteLine("The bag has {0} straps and {1} zippers", c.straps, c.zippers);

            }

            static void SecondVoidStaticMethod()
            {

                Console.WriteLine("Second output");
            }

            static void Main(string[] args)
            {
                VoidDelegate vd = new VoidDelegate(StaticMethodVoid);

                IntDelegate id = new IntDelegate(StaticMethodInt);

                StringDelegate sd = new StringDelegate(StaticMethodString);

                VoidDelegate vd2 = new VoidDelegate(SecondVoidStaticMethod);

                vd();
                vd2();
                Console.WriteLine("The value of {0} double is {1}", 5, id(5));

                string text = "My string text";

                Console.WriteLine("{0} in uppercase is {1}", text, sd(text));


                foreach (char c in text)
                {

                    Console.WriteLine("{0} in ACII2 is {1}", c, (int)c);
                }


                Console.ReadKey();

            }
        }
    }
}
