using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to convert\n");

            string InputFromUser = Console.ReadLine();
            double DoubleVaue = Convert.ToDouble(InputFromUser);
            Console.Write("Enter number to convert\n");

            Console.Write("Enter number to convert\n");

            string y = Console.ReadLine();
            short intTransform = Convert.ToInt16(y);
            Console.WriteLine(InputFromUser + y);
        }
    }
}
