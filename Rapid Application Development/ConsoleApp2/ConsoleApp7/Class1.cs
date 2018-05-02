using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Animal
    {
        //add fields and properties
        //add 2 fields
        //3 properties

        private int teeth; //field
        private double eyes;

        public int Teeth
        {
            get { return teeth; }

            set { teeth = value; }
        }

        public string Species { get; set; }

        public string Color { get; set; }

        public Animal() { }

        public Animal(string Color, string Species, int Teeth)
        {

            this.Color = Color;
            this.Species = Species;
            teeth = Teeth;

        }

        public virtual string GetName()
        {

            return "Animal";

        }
        public bool IsPrimeColor()
        {

            if (Color == "red" || Color == "blue" || Color == "green")
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("The {3} is {0} teeth, is {1} color and is a {2} species ", teeth, Color, Species, GetName());
        }

        ~Animal()
        {

            //write any clean up code

            Console.WriteLine("Cleaning up {0} class", GetName());
        }

    }
}

