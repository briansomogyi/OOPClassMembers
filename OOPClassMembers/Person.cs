using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassMembers
{
    internal class Person
    {
        private string _firstName = "John";
        private string _lastName = "Doe";
        // Readonly field can be modified from the initialization expression
        private readonly string _cnp = "1234";
        public static int PopulationCount = 0;
        public readonly int MaxLifespanYears = InitMaxLifespan();
        // This is a constructor
        public Person(string cnp)
        {
            // Readonly field can be modified from the constructor
            _cnp = cnp;
        }
        public void PrintPerson()
        {
            Console.WriteLine($"{_firstName} {_lastName}");
        }
        public static void PrintPopulationCount()
        {
            Console.WriteLine(PopulationCount);
        }
        public static int InitMaxLifespan()
        {
            Console.Write("Max Lifespan? ");
            bool ok = int.TryParse(Console.ReadLine(), out int result);
            if (ok)
            {
                return result;
            }
            return 0;
        }
    }
}
