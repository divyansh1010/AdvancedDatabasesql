using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_200358605
{
    class Program
    {
        //declare variables 
        public static string name;
        public static Byte percentage;
        public static SByte temperature;
        public static char bloodgroup;
        public static double population;

        public static string @string;
        public static int @int;
        public static Byte @byte;
        public static SByte @sbyte;
        public static UInt32 @uint;
        static void Task1()
        {

            /*
             * Ask the user for a Window Title
             */
             Console.WriteLine("-------------------------Task1---------------------------");
            Console.Write("Enter any Title: ");

            string Title = Console.ReadLine();

            //change window title
            Console.Title = Title;
            Console.Write("Your Title is set to: "+Title
                +"\n");


            /*
             * Ask the user to change window height
             */
            Console.Write("Select any number for changing window height: ");
            string Height = Console.ReadLine();

            //covert string value to UINT
            ushort value = Convert.ToUInt16(Height);
            Console.WindowHeight = value;

            Console.WriteLine("The current height is set to:" +value);
            Console.WriteLine("----------------------End of Task 1-------------------------------\n");
        }

        static void Task2()
        {
            Console.WriteLine("----------------------Task 2-------------------------------");

            // Create 5 identifiers with distinct data types.Use conventional/ proper data types
             name = "Divyansh";
             percentage = 86;
             temperature = 40;
             bloodgroup = 'O';
             population = 1.3;

           
            //Output each identifiers on a new line.
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Percentage: " + percentage);
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("BloodGroup: " + bloodgroup);
            Console.WriteLine("Population: " + population);
            Console.WriteLine("-------------------------End of Task 2---------------------------\n");
        }

        static void Task3()
        {
            Console.WriteLine("-------------------------Task3---------------------------");
            //Create 5 identifiers with distinct data types.Use C# reserved words
             @string = "cultures";
             @int = 8;
             @byte = 28;
             @sbyte = 7;
             @uint = 3287263;


            //outputing all data types
            Console.WriteLine("Different: " + @string);
            Console.WriteLine("Below temperature: " + @int);
            Console.WriteLine("States: " + @byte);
            Console.WriteLine("Lucky number: " + @sbyte);
            Console.WriteLine("Area: " + @uint);

            Console.WriteLine();
            Console.WriteLine("-------------------------End of Task3---------------------------\n");

        }

        static void Task4()
        {
            //concatenation 
            Console.WriteLine("--------------------------------------Task 4----------------------------------------------");
            Console.WriteLine("By concatenation: ");

            Console.WriteLine("Hello my name is {0}.\n" +
                " I am from India. I scored {1} % in my high school." +
                " The temperatures here can go as high as {2} C.\n My blood group is {3} +ve." +
                "Our country's population is about {4} billion." +
                "We can find different {5} in this country. \n" +
                "Here temperatures can go as below + {6} C.\n" +
                "There are {7} states in India." +
                "My lucky number is {8}." +
                "Our country covers about {9} km area of the total world", name, percentage, temperature, bloodgroup, population, @string, @int, @byte, @sbyte, @uint);

            Console.WriteLine();
            //arguments
            Console.WriteLine("By arguments: ");

            Console.WriteLine("Hello my name is " + name + ". I am from India. I scored " + percentage + " marks in my high school.\n " +
                "The temperatures here can go as high as" + temperature + " C. My blood group is " + bloodgroup + " +ve.\n" +
                "Our country's population is about" + population + " billion. We can find different " + @string + " in this country.\n" +
                " Here temperatures can go as below + " + @int + " C.\n There are " + @byte + " states in India." +
                "My lucky number is " + @sbyte + ". Our country covers about " + @uint + " km area of the total world.")  ;

            Console.WriteLine("--------------------------------------End of Task 4----------------------------------------------");
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}