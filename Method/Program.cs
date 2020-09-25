/*ISM 4300 Console Program- Submitted by Alexandra Givins
 Comments: This code demonstrates the use of Method statements after getting input from users. 
*/
using System;

namespace PC
{
    class Program
    {
        static void MyName()
        {
            Console.WriteLine("Please enter your name..");
        }
        static void Main(string[] args)
        {
            //the value of user input 
            Console.WriteLine("Please enter your name..");
            string name = Console.ReadLine();
            //Here is the for the use input 
            Console.WriteLine("Hello" + name + "-" + "Go Bus!");
            {
                Console.WriteLine(" The Program enter your name.");
                // Pause the program and wait for the user to press a key to end the program
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}




