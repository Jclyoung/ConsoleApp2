using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[30];
            int numberOfNames = 0;
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Please enter a name:");
                string name = Console.ReadLine();
                //if (name == "")
                if (String.IsNullOrEmpty(name)) 
                {
                    numberOfNames = i;
                    break;
                }
                names[i] = name;
            }
            //Get a random number between 0 and the number of names entered -1
            int randomInt = new Random().Next(0, numberOfNames - 1);

            //Get the name from the index of the random number
            string nameWinner = names[randomInt];
            //Write winner to the console
            Console.WriteLine($"The Winner is:{nameWinner}!");

        

            //Write a list of names that did not win.

            //Pause with readline

           
            Console.ReadLine();

            
        }
    }
}
