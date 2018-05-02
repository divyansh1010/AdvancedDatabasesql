using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
       

            static void MyRefMethodExample(ref int a)
            {

                a = 99;
            }

            static void MyOutMethodExample(out int b)
            {

                b = 9;
            }

            static void Example1()
            {

                int x, y;
                x = 12;
                y = 25;

                // Console.WriteLine("The orginal values of x and y are {0} and {1}", x, y);
                MyRefMethodExample(ref x);
                MyOutMethodExample(out y);

                Console.WriteLine("The new values of x and y are {0} and {1}", x, y);

            }

            static void Example2()
            {

                Animal a1 = new Animal(12, 50);

                Animal a2 = new Animal(12, 50);
                Animal a3 = a1;

                bool ans1 = a1.Equals(a2);
                bool ans2 = a1.Equals(a2);
                bool ans3 = a1.Equals(5);

                Console.WriteLine("First comparison result = " + ans1);
                Console.WriteLine("Second comparison result = " + ans2);
                Console.WriteLine("Third comparison result = " + ans3);

                /*
                Console.WriteLine(a1.Equals(a2));
                Console.WriteLine(a1.Equals(a3));
                Console.WriteLine(a1.Equals(5));
                */
                Object ob1 = new Object();


                int a, b, c, d;

                a = 12;
                b = 20;
                c = a;
                d = 12;

                /*
                 * Compare using .Equals()
                 *      a to b => False
                 *      a to c => True
                 *      a to d => True
                 *      b to d => False
                 */

                Console.WriteLine(a.Equals(b));
                Console.WriteLine(a.Equals(c));
                Console.WriteLine(a.Equals(d));
                Console.WriteLine(b.Equals(d));


            }

            static void Example3()
            {
                int?[] myInts; //declare not initialized
                myInts = new int?[3]; //initialized

                myInts[0] = 10;
                myInts[1] = null;

                foreach (object itr in myInts)
                {

                    Console.WriteLine(itr);
                }


                int[] MySecondInt = { 3, 2, 1 };

                for (int i = 0; i < MySecondInt.Length; i++)
                {

                    Console.WriteLine("The index {0} stores the value of {1}", i, MySecondInt[i]);

                }
            }
            static void Example4()
            {


                /*
                 * Create an array of 
                 *      2 doubles with any size
                 *      2 strings with any size
                 *      
                 *          Use 3 unique syntaxes for create these arrays
                 * Using 2 different loops
                 *      Display each element on a new line for 2 arrays
                 */

                double[] myDoubleArray;

                double myDoubleValue;

                myDoubleArray = new double[4];

                myDoubleArray[0] = 15;

                myDoubleArray[1] = 15.78;

                myDoubleArray[2] = 5845.454d;

                myDoubleArray[3] = 32442.54D;

                Animal a0;

                a0 = new Animal();

                foreach (double d in myDoubleArray)
                {

                    Console.WriteLine(d);

                }
                Console.WriteLine();

                for (int i = 0; i < myDoubleArray.Length; i++)
                {
                    //can access the index number AND data value

                    Console.WriteLine("index = {0}, value = {1}", i, myDoubleArray[i]);

                }

                string[] myStringArray = { "hello", "world" };
                /*
                List<string> myList = new List<string>(5);

                myList.Add("Hello");
                */
            }

            static void Example5()
            {

                Laptop lp1 = new Laptop();
                lp1.Keys = 200;
                lp1.Resolution = 1920;
                // Laptop lp2 = new Laptop("256SSD");

                Console.WriteLine(lp1.Delete(125));
                Console.WriteLine(lp1.Backlight(125));
                Console.WriteLine(lp1.Keys);
                Console.WriteLine(lp1.Resolution);

            }
            static void Main(string[] args)
            {
                Animal a1 = new Animal(10, 70);
                Animal a2 = new Animal(25, 80);

                Animal a3 = a1 + a2;

                Console.WriteLine("a1 summary is " + a1.ToString());
                Console.WriteLine("a2 summary is " + a2.ToString());
                Console.WriteLine("a3 summary is " + a3.ToString());

                Console.ReadKey();

            }
        }
    }

