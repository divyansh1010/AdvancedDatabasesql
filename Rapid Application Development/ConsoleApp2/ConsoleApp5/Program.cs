using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static public int MyInteger = 12;

        const double MYDOUBLE = 12.34;

        int MyNonStaticInt = 5;

        public static void MyMethod()
        {
            Console.WriteLine("Hello from MyMethod");
        }
        public void MySecondMethod()
        {

            Console.WriteLine(this.MyNonStaticInt);
        }
        static void Task1and2()
        {

            //Console.WriteLine(this.MyNonStaticInt);

            Console.WriteLine("My constant {0} is a double " +
                "value. ", MYDOUBLE);

            short MyShort = 123;

            long MyLong = MyShort; //implicit

            long MyLong2 = (long)MyShort;

            Console.WriteLine("Short value is {0}\nLong value is{1} and {2}",
                MyShort, MyLong, MyLong2);

        }

        static void FirstExamples()
        {
            int MyNumber = 12;

            object obj = (object)MyNumber;

            Program prog = new Program();

            prog.MySecondMethod();

            double average = 8 + 10 / 2;

        }

        static void ExceptionExamplesPart1()
        {

            string answer;
            int intValue;

            Console.Write("Enter number please: ");

            answer = Console.ReadLine();
            try
            {
                intValue = Convert.ToInt32(answer);

                Console.WriteLine("The value you have inputted is " + intValue);

                int a = 10, b = 0;

                Console.WriteLine(a / b);



            }
            catch (FormatException fe)
            {

                Console.WriteLine("Exception Found!\n" +
                    "Exception Name = {0}\n" +
                    "Exception Message = {1}\n" +
                    "Exception Stack Trace = {2}",
                    fe.GetType().Name,
                    fe.Message,
                    fe.StackTrace);

            }
            catch (DivideByZeroException dbze)
            {

                Console.WriteLine(dbze.Message);
            }

        }

        static void ExceptionExamplesPart2()
        {

            try
            {

                string MyString = "Hello";

                Console.WriteLine(MyString[4]); // change to 5 for exception

                string MySecondString = null;


                //Console.WriteLine(MySecondString.ToLower());

                int? MyNullInt = 56;

                int y = MyNullInt ?? 100;

                Console.WriteLine("The value of INT y is " + y);
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);

            }
            catch (NullReferenceException e)
            {
                Console.Write(e.GetType().Name + ":  ");

                Console.WriteLine(e.Message);

            }
        }

        static void ExceptionExamplesPart3()
        {

            //IndexOutOfBounds
            //NullReference

            Console.Write("Enter any input");
            string answer = Console.ReadLine();
            try
            {

                if (answer.ToLower() == "yes")
                {

                    throw new Exception("Not allowed!");
                }
                else if (answer.ToLower() == "no")
                {
                    throw new MyCustomException("No From My Exception");
                }

                Console.WriteLine(answer);

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception Occurred! " + e.Message);
            }
            finally
            {

                Console.WriteLine("Thank you for your time!");
            }



        }
        static void Main(string[] args)
        {
            Task1and2();
            string answer;
            int age;

            Console.Write("Please input anything: ");
            answer = Console.ReadLine();
            Console.WriteLine("Attempting to convert " +
                "{0} into integer", answer);

            try
            {

                age = Convert.ToInt32(answer);

                if (age < 18)
                {
                    throw new MyCustomException("Sorry but you are less than 18");
                }
                else if (age > 64)
                {
                    throw new ArgumentException("Sorry but no seniors allowed");
                }
                //create your own exception 
                //stating that you must be conceived to run this program 

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Could not convert input");
            }
            catch (MyCustomException mce)
            {

                Console.WriteLine("MyCustonException! " + mce.Message);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine("ArgumentException! " + ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} occurred! {1}",
                    e.GetType().Name, e.Message
                    );
            }
            finally
            {
                Console.WriteLine("Thank you for using this application");
            }



            Console.ReadKey();
        }
    }
}

