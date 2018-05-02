using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              * ask user for number input
              * Convert that number input 3 times
              */

            Console.Write("Enter number to convert\n");

            string InputFromUser = Console.ReadLine();

            double DoubleVaue = Convert.ToDouble(InputFromUser);
            //choose two other datatypes to convert

            short intTransform = Convert.ToInt16(InputFromUser);

            Int16 intOtherTransform = Convert.ToInt16(InputFromUser);

            decimal DecTransform = Convert.ToDecimal(InputFromUser);

            float FloatTransform = Convert.ToSingle(InputFromUser);



            //so app won't close in debug mode
            Console.WriteLine("The value on double is {0}.\n"
                + "The value on Short is {1}.\n"
                + "The Value of dec is {2}\n"
                + "The Value of float is {3}\n"
                , DoubleVaue, intTransform, DecTransform, FloatTransform);

            string MyName = "harshdeep";
            string MyMood = "Playing Games";

            Console.WriteLine("My name is {0}.\n I like it when i am {1}", MyName, MyMood);

             

            /*
             * My favorite color is COLOR. My car is COLOR.
             * My dog is COLOR. My fav food is FOOD. I eat FOOD.
             * At least one a month
             * 
             * Output the sentence above using concatenation and arguments
             */
            string MyColor = "Red";
            string MyCarColor = "Black";
            Console.WriteLine("My favorite color is {0}.\n My car color is {1}", MyColor, MyCarColor);

            Console.ReadKey();//inline. OK but not ideal (best practises)


        }
    }
}