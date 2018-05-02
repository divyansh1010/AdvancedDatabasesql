using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Animal
    {
        public int Paws { get; set; }

        public double Whiskers { get; set; }

        public Animal() { }

        public Animal(int paws, double whiskers)
        {

            Paws = paws;
            Whiskers = whiskers;

        }

        public bool Equals(Animal obj)
        {
            Console.WriteLine("Calling MY version of Equals");
            //ReferenceEquals(obj, this);
            //default behaviour for Equals (base.Equals())

            Animal cmp = (Animal)obj;

            //compare each property values to determine
            //if they (the values) are equal

            if (Paws == cmp.Paws && Whiskers == cmp.Whiskers)
            {
                return true;
            }


            return false;
        }

        public static Animal operator +(Animal one, Animal two)
        {

            Animal merged = new Animal();

            merged.Paws = one.Paws + two.Paws;
            merged.Whiskers = one.Whiskers + two.Whiskers;

            return merged;
        }

        public override string ToString()
        {
            return String.Format("This animal has {0} paws and {1} whiskers", Paws, Whiskers);
        }

    }
}
