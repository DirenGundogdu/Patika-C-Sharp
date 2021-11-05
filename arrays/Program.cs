using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] colors = new string[5];
            // string[] animals= {"Cat","Dog","Bird","Monkey"};

            // int[] arr;
            // arr = new int[5];

            // colors[0] = "Blue";

            // arr[3] = 10;

            // Console.WriteLine(animals[1]);
            // Console.WriteLine(arr[3]);
            // Console.WriteLine(colors[0]);

            ///////////////////////////////////////////////////
            Console.WriteLine("Enter Number:");
            int arraylenght = int.Parse(Console.ReadLine());
            int[] numarr = new int[arraylenght];

            for(int i=0; i< arraylenght; i++){
                Console.WriteLine("{0}. enter elements:", i+1);
                numarr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var num in numarr){
                sum += num;
            }
                Console.WriteLine("Average :" + sum/arraylenght);
        }
    }
}
