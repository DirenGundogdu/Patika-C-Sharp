using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion

            byte a = 5;
            sbyte b=30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d:" + d);


            long h = d;
            Console.WriteLine("h:" + h);

            float f = h;
            Console.WriteLine("f:" + f);


            string e = "Diren";
            char i = 'G';
            object g = e + i + d;
            Console.WriteLine("g:" + g);

            Console.WriteLine("**********************************************************************");
            
            //Explicit Conversion

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+ y );

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:"+ t );

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+ v );

            // ToString
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz" + zz);
        }
    }
}
