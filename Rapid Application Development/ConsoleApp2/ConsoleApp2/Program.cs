using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /*Create three other properties in this class
         * 
         */
         
        private int MyProperty = 12;
        private int SecondProperty = 5;

        public static void Main(string[] args)
        {

            Console.Title = "My Console App";

            Console.WindowHeight = 1;

            Console.WindowWidth = 40;

            Console.WriteLine();

            /*
             * resize the Console Window
             * Use random  value and see the result
             * Complete this three times.
             */
            Console.WindowHeight = 3;
            Console.WindowWidth = 51;

            Console.WindowHeight = 5;
            Console.WindowWidth = 48;

            Console.WindowHeight = 6;
            Console.WindowWidth = 61;

        }
    }
}
