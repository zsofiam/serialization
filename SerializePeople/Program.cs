using System;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new("Sanyi", new DateTime(2020, 01,01), Gender.Male);
            Console.WriteLine(person.ToString());
        }
    }
}
