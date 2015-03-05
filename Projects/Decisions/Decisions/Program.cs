using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer what's behind door number 1, 2 or 3?");
            string userValue = Console.ReadLine();

           
            //string message = "";

            //if (userValue == "1")
            //    message = "You won a car!";
            //else if (userValue == "2")
            //    message = "You won a cat!";
            //else if (userValue == "3")
            //    message = "You won a can!";
            //else 
            //    message = "Retard!";

            //Console.WriteLine(message);

            string message = (userValue != "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);

            Console.ReadLine();

        }
    }
}
