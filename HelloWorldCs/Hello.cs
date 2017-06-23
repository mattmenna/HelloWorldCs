using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Taken from https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/hello-world-your-first-program
 * 
 */

namespace HelloWorldCs
{
    class Hello
    {
        static void Main(string[] args)
        {
            String message = "Hello World";

            Console.WriteLine("My message is " + message);
            //Keep the console window open in debug mode.
            Console.WriteLine("Press any Key to Exit.");
            Console.ReadKey();
        }
    }
}
