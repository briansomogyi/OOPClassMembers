using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassMembers
{
    internal class Person
    {
        private string _name;

        // Readonly field can be modified from the initialization expression
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

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public static int PopulationCount { get; private set; } = 0;

        public string Cnp
        {
            get;
        }

        // This is a constructor
        public Person(string cnp)
        {
            // Readonly field can be modified from the constructor
            Cnp = cnp;
            // Each time a person is constructed the population count is incremented by 1
            Person.PopulationCount++;
        }

        public void SayHello()
        {
            // din "exterior" cu proprietatile se lucreaza
            // la fel ca si campurile
            Console.WriteLine($"Hello, my name is {this.Name}");
        }

        public void PrintPerson()
        {
            Console.WriteLine($"{FirstName} {LastName} - CNP: {Cnp}");
        }

        public static void PrintPopulationCount()
        {
            Console.WriteLine(Person.PopulationCount);
        }

        public static int InitMaxLifespan()
        {
            return 125;
            // Console.Write("Max Lifespan? ");
            // return Convert.ToInt32(Console.ReadLine());
        }
    }
}
