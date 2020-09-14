/* 
  Author: Frank Samsock
  Date: 9/13/2020
  Description: This is code created to demonstrate the use of iterative statements 
  after getting input from a user.
*/
using System;

namespace Samsock_Tech_Proj_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value between 1 and 25 to activate an iterative statement: ");
            //Use try catch block to validate the user input
            try
            {
                //Gather data from user input
                string input = Console.ReadLine();
                //Perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                // Keep the initial value for the desired output
                int raw_value = int.Parse(input);

                //Used to test the value of user input
                //The iterative statement will execute.
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a Do While Loop!");
                    Console.WriteLine("The Do While Loop will iterate " + value_of_input.ToString() + " times.");

                    // Do While Loop
                    do
                    {
                        Console.WriteLine("You have entered: " + raw_value + " This is the current integer value of the loop: " + value_of_input.ToString());
                        value_of_input--;
                    } while (value_of_input > 0);
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);

                }  //IF END
                else
                {
                    //If the user enters the wrong thing
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again...");
                    Console.WriteLine("Please press any key to exit the program");
                    Console.ReadKey(true);
                }


            }       //TRY END
            catch
            {
                Console.WriteLine("Please enter an integer value and then try again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }       //Main End
    }   //Class End
}   //Name end
