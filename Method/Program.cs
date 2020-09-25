using System;



namespace Method

{

    class Program

    {

        static void User()
        {
            // Ask the user for input

            Console.WriteLine("Please enter your name..");
        
        }
        private static void Main(string[] args)

        {



        /*

        Use the cath block to validate user input.

        */

        try

        {

            // This variable will gather the user input

            string input = Console.ReadLine();

            

           
            Console.WriteLine("Please enter your name..");
            string name = Console.ReadLine();

            Console.WriteLine("Hello  " + name + " " + "Go Bus!");

                        Console.WriteLine("Press any key to exit the program...");

                        Console.ReadKey(true);

                        

                }// end of try

                catch

                {

                    Console.WriteLine("Please enter your name and try running the program again...");

                    Console.WriteLine("Press any key to exit the program...");

                    Console.ReadKey(true);

                }// End of catch

            }// End of Main

        }// End of Class

    }// End of namesplace