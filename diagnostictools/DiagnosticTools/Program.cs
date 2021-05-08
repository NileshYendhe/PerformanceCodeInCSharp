using System;
using System.Collections.Generic;

namespace DiagnosticTools
{
    class Program
    {
        public static List<PersonClass> PeopleClass = new List<PersonClass>();
        public static List<PersonStruct> PeopleStruct = new List<PersonStruct>();

        static void Main()
        {
            CheckOddOrEven();
            CheckPrime();
            CreatePersonWithStruct();
            CreatePersonWithClass();
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

        private static void CreatePersonWithClass()
        {
            for (int i = 0; i < 1000000; i++)
            {
                PersonClass _personClass = new PersonClass();
                _personClass.Name = "Test Person";
                _personClass.Age = 34;
                PeopleClass.Add(_personClass);
            }
        }

        private static void CreatePersonWithStruct()
        {
            for (int i = 0; i < 1000000; i++)
            {
                PersonStruct _personStruct = new PersonStruct();
                _personStruct.Name = "Test Person";
                _personStruct.Age = 34;
                PeopleStruct.Add(_personStruct);
            }
        }
    }

    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public struct PersonStruct
    {
        public string Name;
        public int Age;
    }
}
