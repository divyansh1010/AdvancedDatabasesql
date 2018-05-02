using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_200358605
{
    public struct Mouse
    {
        public int buttons, lights;
        public string company;

        //Constructor
     public Mouse(int Buttons, int Lights, string Company)
        {
            company = Company;
            buttons = Buttons;
            lights = Lights;
            
        }
    }
    class Assignment2_200358605
    {
        delegate void BoolTask1();
      delegate void IntTask2();

        

        static void Task1()
        {
            //Create a method that determines if a CAPITAL letter exists in a string.
            //The method returns a Boolean
            //The method takes one string argument
            Console.WriteLine("--------------------------------Task 1-----------------------------------------------");
            Console.WriteLine("Please enter any word");
            string value = Console.ReadLine();
            bool IsUpper;
            if (value.Any(char.IsUpper))
                {
                IsUpper = true;
            }
            else
            {
                IsUpper = false;
            }
            Console.WriteLine(IsUpper);

        }

        static void Task2()
        {
            Console.WriteLine("--------------------------------Task 2-----------------------------------------------");
            //Create a method that outputs the sum of the ascii2 values of a string
            //The method returns an integer
            //The method takes one string arguments
            Console.WriteLine("Please enter any two alphabets");
            string value = Console.ReadLine();


            // Convert the string into int
           
            byte[] ASCII = Encoding.ASCII.GetBytes(value);
            
            int total = 0;

            foreach (var i in ASCII)
            {
                total += i; 
            }
            Console.WriteLine(total);


            
        }
        static void Task3()
        {
            Console.WriteLine("--------------------------------Task 3-----------------------------------------------");
            Mouse m;

            Mouse x = new Mouse( 2, 3, "xyz");

            m.company = "xyz";
            m.buttons = 3;
            m.lights = 5;
         
            Console.WriteLine("{0} mouse has {1} buttons and {2} types of lights.", m.company, m.buttons, m.lights);
            Console.WriteLine("{0} mouse has {1} buttons and {2} types of lights.", x.company, x.buttons, x.lights);

        }
            static void Task4()
        {
            Console.WriteLine("--------------------------------Task 4-----------------------------------------------");
            Job Job1 = new Job();

            Job Job2 = new Job(3);

            Job Job3 = new Job(5, 3000);

            Job Job3_1 = new Job(money: 4536, employees: 3, availability: "north of");



            Console.WriteLine(Job1.Availability);
            Console.WriteLine(Job1.Money);

            Console.WriteLine("The job has {0} employees, {1} dollars for each employee and is available in {2} Brampton ", Job3_1.Employees, Job3_1.Money, Job3_1.Availability);

            Console.WriteLine(Job3_1.ToString());


            Console.WriteLine(Job2.ToString());
            Console.ReadKey();
        }
        static void Task5()
        {
            Console.WriteLine("-----------------------------------------Task 5--------------------------------------------------");
            //create delegate instances
            BoolTask1 bt = new BoolTask1(Task1);
            IntTask2 it = new IntTask2(Task2);
            //calling the methods using the delegate objects
            bt();
            it();
           


            Console.ReadKey();
        }
            static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
