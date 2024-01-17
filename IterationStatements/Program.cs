using System.Globalization;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("Printing numbers from 1000 to -1000:\n-------------------------------------------\n");
            PrintThousandToNegThou();
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Printing numbers from 3 to 999:\n-------------------------------------------\n");
            PrintThreeToNNN();

            var numbers = new List<int>();
            Console.WriteLine("\nGive me a number:");
            numbers.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nGive me another number:");

            numbers.Add(int.Parse(Console.ReadLine()));
            CheckEqual(numbers);
            CheckIsEven(numbers);
            CheckIsPos(numbers);

            Console.WriteLine("\nWhat is your age:");
            int age = int.Parse(Console.ReadLine());
            CanVote(age);

            Console.WriteLine("\nWhat number would you like to check:");
            age = int.Parse(Console.ReadLine());
            ISWithinTen(age);
            MultTable(age);
            Console.WriteLine("\n");
        }

        public static void PrintThousandToNegThou()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void PrintThreeToNNN()
        {
            for(int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void CheckEqual(List<int> numbers)
        {
            int num1 = numbers[0];
            int num2 = numbers[1];
            if(num1 == num2)
            {
                Console.WriteLine($"\n{num1} is equal to {num2}\n");
            }
            else
                Console.WriteLine($"\n{num1} is not equal to {num2}\n");
        }

        public static void CheckIsEven(List<int> numbers)
        {
            foreach(int i in numbers)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an Even number");
                }
                else
                    Console.WriteLine($"{i} is an Odd number");
            }
        }

        public static void CheckIsPos(List<int> numbers)
        {
            foreach (int i in numbers)
            {
                if (i >= 0)
                {
                    Console.WriteLine($"{i} is a Positive number");
                }
                else
                    Console.WriteLine($"{i} is a Negative number");
            }
        }

        public static void CanVote(int num)
        {
            if(num >= 18)
            {
                Console.WriteLine("Congrats, you can vote!");
            }
            else
                Console.WriteLine("Sorry, you cannot vote.");
        }

        public static void ISWithinTen(int num)
        {
            if(num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is within 10 and -10");
            }
            else
                Console.WriteLine($"{num} is not within 10 and -10");
        }

        public static void MultTable(int num)
        {
            Console.WriteLine($"\nThe multiples of {num} from 1 - 12 are:");
            for(int i = 1; i < 13; i++)
            {
                Console.Write($"{num * i} ");
            }
        }
    }
}
