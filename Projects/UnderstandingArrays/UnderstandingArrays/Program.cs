using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
            

            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
            

            string[] sentences = new string[] { "Dino is cool!", "Keppet is cute!", "Spock is handsome!", "Grilka is beautiful!" };

            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
            Console.ReadLine();
            */

            string zig = "We are the playmomen! Oeooh! We come from Taiwan" +
                "And you know you want to play with us.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();

        }
    }
}
