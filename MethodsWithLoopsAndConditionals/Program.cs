using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thousand();
            CountingByThree();
            Equal();
            EvenOrOdd();
            PositiveOrNegative();
            CandidateAge();
            InRange();
            MultTable();
        }
    
        public static void Thousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void CountingByThree()
        {
            for (int a = 3; a <= 999; a += 3)
            {
                Console.WriteLine(a);
            }
        }
        public static void Equal()
        {
            int num1;
            int num2;
            Console.WriteLine("enter a number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " are equal");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are not equal");
            }
            
        }
        public static void EvenOrOdd()
        {
            int number;
            Console.WriteLine("enter a number");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("this number is even");
            }
            else
            {
                Console.WriteLine("this number is odd");
            }
        }
        public static void PositiveOrNegative()
        {
            Console.WriteLine("enter a number");
            int answer = int.Parse(Console.ReadLine());
            var response = (answer < 0) ? $"{answer} is negatvie" : $"{answer} is positive";
            Console.WriteLine(response);
        }
        public static void CandidateAge()
        {
            Console.WriteLine("How old are you?");
            var answer = int.Parse(Console.ReadLine());
            if (answer >= 18)
            {
                Console.WriteLine("you are old enough to vote");
            }
            else
            {
                Console.WriteLine("you are too young to vote");
            }
        }
        public static void InRange()
        {
            Console.WriteLine("Enter a number");
            var response = int.Parse(Console.ReadLine());
            if (response >= -10 && response <= 10)
            {
                Console.WriteLine(response + " is within range of -10 and 10");
            }
            else
            {
                Console.WriteLine(response + " is not within range of -10 and 10");
            }
            
        }
        public static void MultTable()
        {
            Console.WriteLine("Enter a number");
            var response = int.Parse(Console.ReadLine());
            for (int multiply = 1; multiply <= 12; multiply++)
            {
                Console.WriteLine("{0} * {1} = {2}",response,multiply,(response * multiply));
            }

        }
    }
}
