using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Laptop : Animal, IScreen, IKeyboard
    {
        private int keys;

        public int Keys
        {
            get
            {
                return keys;
            }
            set
            {
                keys = value;
            }
        }

        public int Resolution { get; set; }

        public string Harddrive { get; set; }
        public Laptop() { }
        public Laptop(string HD)
        {

            Harddrive = HD;
        }
        public string Backlight(int brightness)
        {

            switch (brightness)
            {

                case 100:
                    return "Super Bright";

                case 80:
                    return "Bright";

                case 50:
                    return "Normal";
                default:
                    return "Unknown";
            }

        }

        public bool Delete(int keyNumber)
        {

            if (keyNumber == 127)
                return true;

            return false;

        }

    }
}

