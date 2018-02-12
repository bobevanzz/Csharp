using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            AskSportsQuestion();
            Console.ReadLine();
        }

        private static void AskSportsQuestion() //this could always be refactored 
                                                //with right click to hide if and else 
                                                //parameters
        {
            string input;
            do //do while loop is made at the end, not right now
            {


                // get input/ declare variables, assign them

                Console.WriteLine("Enter the best Baseball team:");
                input = Console.ReadLine();

                // test input /if else
                if (input == "Reds" ||   
                    input == "Cincinnati" ||
                    input == "cincinnati" ||
                    input == "Cincinnati Reds" ||
                    input == "cincinnati reds" ||
                    input == "Cincinnati reds" ||
                    input == "cincinnati Reds" ||
                    input == "reds"
                    )
                {
                    Console.WriteLine("Yes!");
                    break;
                }
                else
                {
                    // respond
                    Console.WriteLine("Try again...");
                }
            } while (!(input == "Reds" ||
                    input == "Cincinnati" ||
                    input == "cincinnati" ||
                    input == "Cincinnati Reds" ||
                    input == "cincinnati reds" ||
                    input == "Cincinnati reds" ||
                    input == "cincinnati Reds" ||
                    input == "reds"));

            //do it again
            Console.WriteLine("Thank you!");
        }
    }
}
