using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine(time);
            if(time >= 6 && time<11)
            Console.WriteLine("Good Morning");
            else if(time <= 15)
            Console.WriteLine("Good Day");
            else
            Console.WriteLine("Good Night");

            string result = time <= 18 ? "Good Day" : "Good Night";
            Console.WriteLine(result);
        }
    }
}
