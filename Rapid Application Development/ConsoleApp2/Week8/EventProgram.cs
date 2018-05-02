using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    class EventProgram
    {
        public event MyMath DoCalc;


        static int Add(int x, int y)
        {
            Console.WriteLine("Add called!");
            return x + y;
        }

        int Divide(int x, int y)
        {
            Console.WriteLine("Divide called!");

            return x / y;
        }

        public Program()
        {

            DoCalc += Divide;


        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int result = p.DoCalc(12, 20);
            Console.WriteLine(result);

            p.DoCalc += p.Divide;

            int result_1 = p.DoCalc(22, 20);
            Console.WriteLine(result_1);


            /*
            * Create a non-static method that returns the quotient of two numbers
            * 
            * Add this new method to your DoCalc event
            * 
            * Output the result of passing any two numbers
            * To the DoCalc event
            */
            Console.ReadKey();
        }
    }
}

    
