namespace OOPClassMembers
{
    public class Program
    {
        public static void Main()
        {
            int numberOfPersons = ReadNumber("Number of Persons: ", 3);
            Person[] arrayOfPersons=new Person[numberOfPersons];
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.WriteLine($"Reading person at index {i}: ");
                
                Console.Write("FirstName: ");
                string firstName = Console.ReadLine();

                Console.Write("LastName: ");
                string lastName = Console.ReadLine();

                Console.Write("CNP: ");
                string cnp = Console.ReadLine();

                Person p = new Person(cnp);
                p.FirstName = firstName;
                p.LastName = lastName;

                arrayOfPersons[i] = p;
            }

            Console.WriteLine("Printing persons: ");
            for (int i = 0;i< arrayOfPersons.Length;i++) 
            {
                // arrayOfPersons[i].PrintPerson();
                Person p = arrayOfPersons[i];
                Console.WriteLine($"{p.FirstName} {p.LastName} - CNP: {p.Cnp}");
            }

            Console.WriteLine($"Total population count: {Person.PopulationCount}");
        }

        public static int ReadNumber(string label, int maxAttempts)
        {
            int attempts = 1;
            do
            {
                Console.Write(label);
                string input = Console.ReadLine();
                bool isValidNumber = int.TryParse(input, out int result);

                if (isValidNumber)
                {
                    return result;
                }

                if (attempts < maxAttempts)
                {
                    Console.WriteLine($"Value '{input}' is not a valid number, please try again.");
                }

                attempts++;
            }
            while (attempts <= maxAttempts);

            Console.WriteLine($"No valid numeric input, continuing with 0 as default value.");
            return 0;
        }
    }
}