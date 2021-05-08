using System;

namespace PerfTips
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program Started");
            CheckOddOrEven();
            CheckPrime();
            Console.WriteLine("Program Completed");
        }

        private static void CheckOddOrEven()
        {
            int num1 = 150, rem1;
            rem1 = num1 % 2;
            if (rem1 == 0)
            {
                Console.WriteLine("{0} is an even number.\n", num1);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.\n", num1);
            }
        }

        private static void CheckPrime()
        {
            int number = 150;
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("{0} is not a prime number.\n", number);
                }
            }
            if (i == number)
            {
                Console.WriteLine("{0} is a prime number.\n", number);
            }
            Console.WriteLine("{0} is not a prime number.\n", number);
        }
    }
}
