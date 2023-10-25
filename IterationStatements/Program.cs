using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();


            //Create a variable of type int and name it num
            var num = 0;

            //{
            //    // Increment num by 1
            //    myNumber++;

            //    // Then add num to the collection - numbers
            //    // Hint: reference num inside of the Add method's parentheses
            //    numbers.Add(myNumber);

            //} // <---- While your variable is less than 100
            do
            {
                num++; //2                 // Then add num to the collection numbers
                numbers.Add(num); //1,2,3,4 100

            } while (num < 100);

            while (num < 200)
            {
                num++; //1  == num = num + 1;
                numbers.Add(num); 
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers
            foreach (var item in numbers)
            {
             Console.WriteLine($"{item}");
            }


                Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop 
            // in your initializer set the value of i to 199
         // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}"); 
            }

            //------------End of exercise
        }
    }
}
