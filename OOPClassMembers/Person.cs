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
        private string _name;

        private static int _populationCount = 0;
        
        // Readonly field can be modified from the initialization expression
        private readonly string _cnp = "1234";
        public readonly int MaxLifespanYears = InitMaxLifespan();
        
        // aceasta este o proprietate
        public string Name
        {
            get // codul executat la citire
            {
                if (this._name is null)
                {
                    this._name = string.Empty;
                }

                return this._name;
            }
            set // codul executat la scriere
            {
                // in acest context "value" este un cuvant cheie
                // care tine locul valorii care se scrie
                if (string.IsNullOrWhiteSpace(value))
                {
                    value = string.Empty;
                }

                this._name = value;
            }
        }

        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        public static int PopulationCount
        {
            get { return Person._populationCount; }
            set { Person._populationCount = value; }
        }

        public string Cnp
        {
            get { return this._cnp; }
        }

        // This is a constructor
        public Person(string cnp)
        {
            // Readonly field can be modified from the constructor
            this._cnp = cnp;
            // Each time a person is constructed the population count is incremented by 1
            Person._populationCount++;
        }

        public void SayHello()
        {
            // din "exterior" cu proprietatile se lucreaza
            // la fel ca si campurile
            Console.WriteLine($"Hello, my name is {this.Name}");
        }

        public void PrintPerson()
        {
            Console.WriteLine($"{_firstName} {_lastName}");
        }

        public static void PrintPopulationCount()
        {
            Console.WriteLine(Person._populationCount);
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
