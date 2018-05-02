using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    interface IScreen
    {
        int Resolution { get; set; } //property

        // double NotGoingToWork;

        string Backlight(int brightness); //method


    }

    interface IKeyboard
    {

        int Keys { get; set; }

        bool Delete(int keyNumber);

    }

}

