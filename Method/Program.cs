using System;

namespace PC
{
    class Program
    {
        static void UserName()
        {
            Console.WriteLine("Please enter your name..");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name..");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "  " + " Go Bus!");
            {
                Console.WriteLine(" The Program enter your name.");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}



