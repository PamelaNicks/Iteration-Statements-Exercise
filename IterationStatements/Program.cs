using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintRange();
            EveryThird();
            Console.WriteLine(TwoIntegers(a, b));
            EvenOrOdd(number);
            Console.WriteLine(IsPositive(number));
            Console.WriteLine(OfVotingAge(age));

            Console.WriteLine(IsInRange(number));
            DisplayMultiplicationTable(number);
        }

        //1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //inside main: PrintMain();
        public static void PrintRange()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        // inside main: EveryThird();
        public static void EveryThird()
        {

            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        // if else and a bool return is how we write this example

        //i do not like syntax sugar so i would write it like this:
        //if(a == b)
        //{
        //return true;
        //}
        //return false;

        //inside main:  Console.WriteLine(TwoIntegers(1, 2));

        public static bool TwoIntegers(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;

        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        //inside main: EvenOrOdd(3);

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"even");
            }
            else
            {
                Console.WriteLine($"odd");
            }

        }

        //5. Determine if a number is positive, return value is true if positive or false if negative

        public static bool IsPositive(int number)
        {
            if (number > 0)
            {
                return true;
            }
            return false;
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.

        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes they are of voting age");
                return true;
            }
            else
            {
                Console.WriteLine($"Too young to vote by {18 - age} years");
                return false;
            }
        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange(int number)
        {
            if (number >= -10 && number <= 10)
            {
                return true;
            }
            return false;
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
               
                Console.WriteLine($"{i} * {number} = {number * i}");
            } 
        }
    }
}

  


