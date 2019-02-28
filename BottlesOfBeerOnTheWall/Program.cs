using System;

namespace BottlesOfBeerOnTheWall
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Output "99 bottles of beer on the wall.  99 bottles of beer.  Take 1 down and pass it around, 98 bottles of beer on the wall.";
            // Count down until there are no more bottles of beer on the wall.

            
            for(int i = 99; i >= 1; i--)
            { 
                Console.WriteLine( i + " bottles of beer on the wall, " + i + " bottles of beer.");
                i--; Console.WriteLine(" Take one done and pass it around " + i + " bottles of beer on the wall.");

                i++; if (i == 3)

                {   
                    Console.WriteLine("2 bottles of beer on the wall, 2 bottles of beer.");
                    Console.WriteLine("Take one down pass it around 1 bottle of beer on the wall.");
                    Console.WriteLine("Take one down and pass it around and now there are no more bottles of beer on the wall!");

                    Console.ReadLine();
                    break;

                }
            
                 
           }

            
        }
    }
}
