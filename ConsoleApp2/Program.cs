using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the total bill amount?");
            string billInput = Console.ReadLine();
           // billInput = billInput.Trim(); //removes white space before and after return
           // billInput = billInput.Trim('$');
            billInput = billInput.Trim().Trim('$');

            // Look up how to do expressions and how to extract just a number
            
            Console.WriteLine("What percentage would you like to tip?");
            string tipPercentInput = Console.ReadLine();
            //tipPercentInput = tipPercentInput.Trim();
            //tipPercentInput = tipPercentInput(%)
            tipPercentInput = tipPercentInput.Trim().Trim('%');

            double tipPercent;
            if (!double.TryParse(tipPercentInput, out tipPercent))
            {
                Console.WriteLine($"The value {tipPercentInput} is not a valid tip");
            }

            double bill;
            if (!double.TryParse(billInput, out bill))
            {
                Console.WriteLine($"The value {billInput} is not a valid amount.");
            }
            //double bill = double.Parse(billInput);
            //int tipPercent = int.Parse(tipPercentInput);
            double tipAmount = Math.Round( tipPercent * bill / 100, 2);
            double totalBill = Math.Round( bill + tipAmount, 2);
            //double roundedTipAmount = Math.Round(tipAmount, 2);
            // totalBill = Math.Round(totalBill, 2);

            //string tipAmountString = tipAmount.ToString();

            Console.WriteLine($"Your total  tip amount is ${tipAmount}.");
            Console.WriteLine($"Your total bill amount is ${totalBill}");

            Console.ReadLine();

            //
            //display input and ask user if correct or would like to change amount
            //input from user
            //
            //display total amount with tip added
            //ask user if accurate
            //get input


        }
    }
}
