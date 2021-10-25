using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("");

              byte b = 5;        //1 byte
              sbyte c = 5;       //1 byte

              short s = 5;        //2 byte
              ushort us = 5;      //2 byte

              Int16 i16 = 5;      //2 byte
              int i = 2;          //4 byte
              Int32 i32 = 2;      //4 byte
              Int64 i64 = 2;      //8 byte

              uint ui = 2;        //4 byte
              long l = 4;         //4 byte
              ulong ul = 5;       //8 byte

              //Reel sayılar
              float f = 5;        //4 byte
              double d = 5;       //8 byte
              decimal de = 5;     //16 byte

              char ch = '2';      //2 byte
              string str = "Zikriye"; //unlimited

              bool b1 = true;
              bool b2 = false;

              DateTime dt = DateTime.Now;

              Console.WriteLine(dt);

              object o1 = "x";
              object o2 = 'y';
              object o3 = 4;
              object o4 = 4.3;
              
              // string expressions

              string str1 = string.Empty;
              str1 = "Diren Gündoğdu";
              string name = "diren";
              string surname = "gündoğdu";
              string fullName = name + " " + surname;

              //integer

              int integer1 = 5;
              int integer2 = 3;
              int integer3 = integer1 + integer2;

              //boolean

              bool bool1 = 10>2;

              //variable change
              string str20 = "20";
              int int20 = 20;
              string newValue = str20 + int20.ToString();
              Console.WriteLine(newValue);

              int int22 = int20 + int.Parse(str20);

              //datetime

              string datetime = DateTime.Now.ToString("dd.MM.yyyy");
              Console.WriteLine(datetime);

              string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
              Console.WriteLine(datetime2);

              //saat
              string hour = DateTime.Now.ToString("HH:mm");
              Console.WriteLine(hour);

    }
    }
}
