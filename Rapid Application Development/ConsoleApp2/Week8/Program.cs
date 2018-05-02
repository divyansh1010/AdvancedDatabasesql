using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{

    delegate string MyStringDel(string s, string t);

    class Program
    {
        static string ReturnBiggerString(string one, string two)
        {

            Console.WriteLine("BiggerString called");

            if (one.Length > two.Length)
                return one;

            return two;
        }

        static string ReturnSmallerString(string one, string two)
        {

            Console.WriteLine("SmallerString called");

            if (one.Length < two.Length)
                return one;

            return two;

        }
        static void Example1()
        {

            MyStringDel Steve = ReturnBiggerString;

            Steve += ReturnSmallerString;

            MyStringDel Ben = new MyStringDel(ReturnSmallerString);

            string name1, name2;

            name1 = "Steve";

            name2 = "Bob";

            string firstReturn = Steve(name1, name2);

            Console.WriteLine("The string that has  the most amount of " +
                "characaters between '{0}' and '{1}' is '{2}'",
                name1, name2, firstReturn);

            Steve -= ReturnSmallerString;

            string firstReturn_two = Steve(name1, name2);

            Console.WriteLine("The string that has  the most amount of " +
                "characaters between '{0}' and '{1}' is '{2}'",
                name1, name2, firstReturn_two);

            /*
             * Out the result of the delegate named Ben
             * Pass the same params as our Steve delegate.
             */
            /*
           string secondReturn = Ben(name1, name2);

           Console.WriteLine("The smaller text between " +
               "'{0}' and '{1}' is '{2}'",
               name1, name2, secondReturn);
               */


            /*
             * Add two more methods to the Ben delegate
             * 
             * Call and see the output of Ben
             * Remove one of the three methods to the Ben delegate
             * 
             * Call and see the output of Ben
             */
            Console.WriteLine();
            Console.WriteLine();
            Ben += ReturnBiggerString;
            Ben += ReturnSmallerString;

            string secondReturn_one = Ben(name1, name2);

            Console.WriteLine("Calling the Ben delegate with the parameters" +
               "'{0}' and '{1}' is '{2}'",
               name1, name2, secondReturn_one);

            Ben -= ReturnBiggerString;

            string secondReturn_two = Ben(name1, name2);
            Console.WriteLine("Calling the Ben delegate with the parameters" +
               "'{0}' and '{1}' is '{2}'",
               name1, name2, secondReturn_two);


        }

        static void Example2()
        {

            Shirt tShirt = new Shirt();


            Console.WriteLine("The result of !Shirt tShirt is " + !tShirt);

            Shirt dressShirt = new Shirt("White", 100, 80);

            /*
             * Override the ToString() method
             *      Output the three properties
             *  
             *  Add an Interface named IPockets to the Shirt Class
             *      It should have 2 Properties
             *      It should have 2 methods
             *  
             *  Add support so that the Shirt class can complete the following operators
             *          Increments
             *          Decriment
             *          
             *          Multiplication
             *          Division
             *  
             * 
             */

            Shirt longSleeve = new Shirt("Blue", 27, 63);

            Shirt merged = dressShirt * longSleeve;

            Console.WriteLine("The multiplication of dressShirt and longSleever" +
                " is" + merged.ToString());

        }

        static void LoopThruArray(string[] theArray)
        {

            foreach (string item in theArray)
            {
                Console.WriteLine(item);
            }

        }
        static void LoopThruArray(int[] theArray)
        {

            foreach (int num in theArray)
            {
                Console.WriteLine(num);
            }

        }
        static bool AlterArray(int[] theArray, int index, int newValue)
        {


            if (index >= 0 && index < theArray.Length)
            {

                theArray[index] = newValue;
                return true;
            }

            return false;

        }
        static void Main(string[] args)
        {

            int[] myNumbers;
            string[] myNames;

            myNumbers = new int[5];

            myNames = new string[5];

            LoopThruArray(myNumbers);
            //LoopThruArray(myNames);

            Console.WriteLine("----------");

            AlterArray(myNumbers, 11, 76);

            LoopThruArray(myNumbers);

            Console.ReadKey();
        }
    }
}

