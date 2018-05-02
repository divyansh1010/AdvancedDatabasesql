using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            char Mychar = 'A';

            //char WrongChar = '';

            char NewLine = '\n';

            char Alert = '\a';
            /*
             * 
             *  \b =backspace
             *  \t = horizontal tab
             *  \v = vertical tab
             */

            char LetterA = '\x41';


            Console.WriteLine(Alert);
            Console.WriteLine(LetterA);
            Console.ReadKey();
        }
    }
}
