using System;

namespace console_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Hello " + name + " " + surname);
        }
    }
}
