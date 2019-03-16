using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = 0;


            // Create a simple calculator that asks the user to input two different numbers 
            Console.WriteLine("Please enter your first number:");
            string firstNumberInput = Console.ReadLine();
            firstNumberInput = firstNumberInput.Trim();

            double firstNumber;
            if (!double.TryParse(firstNumberInput, out firstNumber))
                Console.WriteLine($"The value {firstNumberInput} is not a valid number.");
           

            Console.WriteLine("Please enter your second number:");
            string secondNumberInput = Console.ReadLine();
            secondNumberInput = secondNumberInput.Trim();

            double secondNumber;
            if (!double.TryParse(secondNumberInput, out secondNumber))
                Console.WriteLine($"The value {secondNumberInput} is not a valid number.");


            

            Console.WriteLine("Please enter if you would like to add, subtract, multiply or divide: ");
            string operation = Console.ReadLine();

            double answer = 0;

            if (operation == "add")
            {
                answer = (firstNumber + secondNumber);
                Console.WriteLine(firstNumber + " + " + secondNumber + " = " + answer);
            }
            else if (operation == "subtract")
            {
                answer = (firstNumber - secondNumber);
                Console.WriteLine(firstNumber + " - " + secondNumber + " = " + answer);
            }
            else if (operation == "divide")
            {
                answer = (firstNumber / secondNumber);
                Console.WriteLine(firstNumber + " / " + secondNumber + " = " + answer);
            }
            if (operation == "multiply")
            {
                answer = (firstNumber * secondNumber);
                Console.WriteLine(firstNumber + " * " + secondNumber + " = " + answer);
            }           

            
                // and whether they want to add, subtract, multiply or divide them. 

                Console.WriteLine($"Total = {answer}");

                Console.ReadLine();

            





        }
    }
}
