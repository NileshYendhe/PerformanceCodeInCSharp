using System.Collections.Generic;

namespace PerformanceProfiler
{
    class Program
    {
        public static List<PersonClass> PeopleClass = new List<PersonClass>();
        public static List<PersonStruct> PeopleStruct = new List<PersonStruct>();

        static void Main()
        {
            CreatePersonWithStruct();
            CreatePersonWithClass();
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
