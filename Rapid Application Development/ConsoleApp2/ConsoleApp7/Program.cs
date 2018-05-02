using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        static void Example1()
        {

            Animal a1 = new Animal();

            a1.Teeth = 100;

            a1.Color = "brown";

            a1.Species = "Tiger";

            Animal a2 = new Animal(Color: "orange", Species: "lion", Teeth: 123);

            Console.WriteLine(a1.ToString());

            Lion lion_1 = new Lion();

            lion_1.Color = "red";
            lion_1.Species = "lion";
            lion_1.Teeth = 300;


            Lion lion_2 = new Lion();

            Console.WriteLine(lion_1.ToString());

            Console.WriteLine("Does A1 have a prime color? {0} \nDoes Lion 1 have a prime color? {1} ",
                a1.IsPrimeColor(), lion_1.IsPrimeColor()
                );
        }

        static void Example2()
        {
            //Engine e1 = new Engine();

            Car c1 = new Car(5);

            Console.WriteLine(c1.ToString());

            Animal a2 = new Animal();

            GC.Collect();
        }
        static void Main(string[] args)
        {
            Student s1 = new Student(Name: "John Doe");

            // Console.WriteLine("The Student Name is " + s1.Name);

            Factorial(5);
            Console.WriteLine();
            FactorialLoop(5);

            Console.ReadKey();
        }

        static int FactorialLoop(int num)
        {

            //if num = 5
            //result is 

            /*
             * 5 x 4 x 3 x 2 x 1 = 120 
             */
            int result = 1;



            //for (int i = 1; i <= num; i++) {
            //    result *= i;
            //    Console.WriteLine("i = {0}, result = {1}", i, result);
            //}

            for (int i = 0; i < num; i++)
            {
                result *= (i + 1);
                Console.WriteLine("i = {0}, result = {1}", i, result);
            }

            return result;

        }

        static int Factorial(int num)
        {

            Console.WriteLine("Calling factorial with num = " + num);

            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                Console.WriteLine("Num = {0}.  Result of {0} * Factorial({1}) = {2}", num, num - 1, result);

                return result;
            }
        }
    }

}
