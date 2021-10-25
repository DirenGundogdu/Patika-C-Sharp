using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment and Operational Assignment
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 5;
            Console.WriteLine(x);

            // Logical Operators
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            // Relational Operators
             int a = 3;
             int b = 4;
             bool result = a<b;

             Console.WriteLine(result);
             result = a>b;
             Console.WriteLine(result);
             result = a>=b;
             Console.WriteLine(result);
             result = a<=b;
             Console.WriteLine(result);
             result = a==b;
             Console.WriteLine(result);
             result = a!=b;
             Console.WriteLine(result);

            
            // Arithmetic
            int count1 = 10;
            int count2 = 4;
            int result1 =  count1/count2;
             Console.WriteLine(result1);
            result1 = count1*count2;
             Console.WriteLine(result1);
            result1 = count1+count2;
             Console.WriteLine(result1);
            result1 = count1++;
             Console.WriteLine(count1);

             int result2 = 20%3;
             Console.WriteLine(result2);
        }
    }
}
