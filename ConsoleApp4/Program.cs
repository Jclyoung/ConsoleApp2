using System;

namespace Mileage
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("How many miles have you driven? ");
            string mileageInput = Console.ReadLine();
            mileageInput = mileageInput.Trim();

            Console.Write("How many gallons of gas have you consumed? ");
            string gasConsumedInput = Console.ReadLine();
            gasConsumedInput = gasConsumedInput.Trim();

            float mileage;
            float.TryParse(mileageInput, out mileage);
            
            

            float gasConsumed;
            float.TryParse(gasConsumedInput, out gasConsumed);

            float milesPerGallon = (mileage / gasConsumed);

            Console.WriteLine($"Your miles per gallon is {milesPerGallon}");
            
            // Get input from the user and save it to a second variable.

            // Output - Your miles per gallon is (computed value)

            Console.ReadLine();
        }
    }
}
