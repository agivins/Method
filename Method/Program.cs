/*ISM 4300 Console Program- Submitted by Alexandra Givins
 Comments: This code demonstrates the use of Method statements after getting input from users. 
*/

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



      

        try

        {

            // This variable will gather the user input

            string input = Console.ReadLine();

            

           
            Console.WriteLine("Please enter your name..");
            string name = Console.ReadLine();
                //Here is the the user input 
                Console.WriteLine("Hello  " + name + " " + "Go Bus!");

                        Console.WriteLine("Press any key to exit the program...");

                        Console.ReadKey(true);

                        

                }// end of try
                 /*

           Use the cath block to validate user input.

           */
            catch

            {
                // Pause the program and wait for the user to press a key to end the program
                Console.WriteLine("Please enter your name and try running the program again...");

                    Console.WriteLine("Press any key to exit the program...");

                    Console.ReadKey(true);

                }// End of catch

            }// End of Main

        }// End of Class

    }// End of namesplace