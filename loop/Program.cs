using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter Number");
            // int num =int.Parse(Console.ReadLine());
            // for (int i=0; i<=num; i++){
            //     if (i%2 == 1){
            //         Console.WriteLine(i);
            //     }
            // }
            /////////////////////////////////
            // int counter = 1;
            // int sum = 0;
            // while (counter <= num){
            //     sum += counter;
            //     counter ++;
            // }
            //     Console.WriteLine(sum/num);

            ///////////////////////////////////////////////////////////
                // char character = 'a';
                // while (character < 'z'){
                //     Console.WriteLine(character);
                //     character ++;
                // } 
             ///////////////////////////////////////////////////////////

             string[] cars = {"BMW","Ferrari","Bentley","Bugatti","Aston Martin", "Lamborghini"};
             foreach (var car in cars){
                 Console.WriteLine(car);
             }
        }
    }
}
