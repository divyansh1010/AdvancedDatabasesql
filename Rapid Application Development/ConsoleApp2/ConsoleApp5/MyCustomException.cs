using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyCustomException : Exception

    {

        public MyCustomException() { }

        public MyCustomException(string message) : base(message)
        {


        }

    }
}

