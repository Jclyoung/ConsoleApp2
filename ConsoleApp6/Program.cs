using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of the month: ");
            string monthInput = Console.ReadLine();
            monthInput = monthInput.Trim();
            int month;
            int.TryParse(monthInput, out month);

            string message = "";

            if (month == 1)
                message = "January";
            if (month == 2)
                message = "February";
            if (month == 3)
                message = "March";
            if (month == 4)
                message = "Arpil";
            if (month == 5)
                message = "May";
            if (month == 6)
                message = "June";
            if (month == 7)
                message = "July";
            if (month == 8)
                message = "August";
            if (month == 9)
                message = "September";
            if (month == 10)
                message = "October";
            if (month ==11)
                message = "November";
            if (month == 12)
                message = "December";
           
            

            Console.WriteLine($"The name of the month you entered is {message}");

            Console.ReadLine();




            // Save the input to a variable.

            // Use the if statment to update the monthName variable based on the user's input.
            //string monthName = string.Empty;


            
        }
    }
}
