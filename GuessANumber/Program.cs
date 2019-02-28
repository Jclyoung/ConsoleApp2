using System;


namespace GuessANumber
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number between 1 and 10: ");
            string numberInput = Console.ReadLine();

            string message = (numberInput == "8") ? "You Win!" : "You Lose.";


            /* if (numberInput == 8)
                 message = "You Win!";
             else
                 message = "You Lose.";
                 */

            Console.WriteLine("{0}", message);
            Console.ReadLine();
            



            


            // If they enter 8, output “You Win!”. Otherwise, output “You Lose.”. Do this using an inline if statement.

            Console.ReadLine();
        }
    }
}