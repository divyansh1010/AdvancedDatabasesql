using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                throw new ArgumentException("A start-up parameter is required.");
            }

            Console.WriteLine("{0} argument(s) provided", args.Length);
            Console.ReadKey();
        }
        
    }

}