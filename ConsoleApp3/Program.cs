using System;

namespace ConsoleApp3
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            {

               
                    Console.Write("Enter the length of the rectangle:");
                   
                // Get input from the user and save it to a variable.

                string lengthInput = Console.ReadLine();
                lengthInput = lengthInput.Trim().Trim('"');
                    lengthInput = lengthInput.Trim('.');
                
                double length;
                if (!double.TryParse(lengthInput, out length))
                {
                    Console.WriteLine($"The value {lengthInput} is not a valid number for length");
                }
                
                // Get input from the user and save it to a second variable.

                Console.Write("Enter the width of the rectangle: ");
                string widthInput = Console.ReadLine();
                widthInput = widthInput.Trim();

                double width;
                if (!double.TryParse(widthInput, out width))
                {
                    Console.WriteLine($"The value {widthInput} is not a valid number for width");
                }

                double rectangleArea = (length * width);
                Console.WriteLine($"The total area of the rectangle is {rectangleArea}");
                
                // Output - The area of the rectangle is (computed value)

                Console.ReadLine();
            }
        }

     }   
}
