using System;

namespace LaunchScrabble
{
    class Program
    {
        static void Main(string[] args)
        {

            //Have user input a list of coma seperated words
            //Convert user input into an array of words
            int[] someVariable = new int[9];
            int score = 0;
            //For each word....
            //Check if word begins with a q
            string someString = "findmyfirstletter";
            someString = someString.ToLower();
            char firstChar = someString[0];
            char secChar = someString[1];
            if (firstChar == 'q')
            {
                if (secChar == 'u')
                {

                    score = score + 10;

                }
                else
                {
                    score = 0;

                }


            }
            else
            {
                score = score++;
            }




                


        }
            //If so, check if next is u
            //if it is not, return 0
            //If it is, add 10 to their score
            //else add 1 to their score

            //return score















        


    //    public static string ()
    //    {

    ////     0  1  2  3  4  5
    //int[] numbers = { 1, 2, 3, 4, 5, 6 };

    //// This will print out the type of array
    ////Console.WriteLine(numbers);
    ////Console.ReadLine();


    //string output = String.Join(",", numbers);
    //Console.WriteLine(output);

    //        string someNumberString = "23, 64, 33, 9, 110";
    //string[] someStringArrayOfNumbers = someNumberString.Split(',');
    //int[] someArrayOfInts = new int[someNumberString.Length];
    //        for(int i = 0; i<someStringArrayOfNumbers.Length; i++)
    //        {
    //            int number = Convert.ToInt32(someStringArrayOfNumbers[i]);
    //someArrayOfInts[i] = number;

             
        


            
    //   Console.ReadLine();

     }
}
