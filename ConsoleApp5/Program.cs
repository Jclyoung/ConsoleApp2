using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string standardGreeting = "Hello, " + name + ".";
            if (name == "Amar")
            {
                Console.WriteLine("Hello, " + name + ". You seem like an interesting person");

            }
            else if (name == "Brandy")
            {
                Console.WriteLine("Hello, " + name + ". You seem like a cool person.");
            }
            else
            {
                Console.WriteLine("Hello" + name);
            }

            Console.ReadLine();



        }
    }
}
