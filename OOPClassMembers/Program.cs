namespace OOPClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("2344");
            // Console.WriteLine(p._firstName);
            // Console.WriteLine(p._lastName);
            Console.WriteLine(p.MaxLifespanYears);
            // Console.WriteLine(p._cnp);
            Person.PopulationCount = 1;
        }
    }
}