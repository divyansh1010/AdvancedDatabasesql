using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   class House
    {
        private int roof;
        protected double rooms;
        public string Floors;

        public int Roof
        {

            set { roof = value; }

            get { return roof; }

        }

        public double Rooms {

            private set { rooms = value;  }

            get { return rooms; }

        }

        public House() { }

        //        public House(int theRoof) {
        public House(int roof)
        {

            this.roof = roof;
            //roof = theRoof;
        }
        public House(float roof) {

            this.roof = (int)roof;
        }

        public House(int roof, double rooms) : this(roof) {
//            //this.roof = roof;
            this.rooms = rooms;

        }

        //add a third constructor that allows 3 arguments
        //call a previous contructor

        public House(int roof, double rooms, string floors):this(roof, rooms) {

            //this.Floors = floors;
            Floors = floors;

        }

        public override string ToString()
        {
            return "The house has " + Floors + " floors and " + rooms + " rooms and " + roof + " roofs";
        }

    }
}

