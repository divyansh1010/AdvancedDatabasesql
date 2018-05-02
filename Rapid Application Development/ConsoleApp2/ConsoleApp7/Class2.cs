using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Lion : Animal
    {
        public double Whiskers { get; set; }

        public Lion() { }

        public Lion(string Color, string Species, int Teeth) : base(Color: Color, Species: Species, Teeth: Teeth)
        {
        }

        public Lion(string Color, string Species, int Teeth, double Whiskers) : base(Color: Color, Species: Species, Teeth: Teeth)
        {
            this.Whiskers = Whiskers;
        }

        new public bool IsPrimeColor()
        {
            if (Color == "orange" || Color == "black")
                return true;
            return false;
        }

        public override string GetName()
        {
            return "Lion";
        }
    }
}

