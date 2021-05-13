using System;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLineWithOwner("value", consumer: nameof(Program));
            WriteLineWithOwner("value");
            //void Sum(params int[] values)
            //{
            //    int sum = 0;
            //    if (values.Length == 0)
            //    {
            //        Console.WriteLine("no params");
            //        return;
            //    }

            //    foreach (var value in values)
            //    {
            //        sum += value;
            //    }

            //    Console.WriteLine("Sum " + sum);
            //}


            ////Sum(1, 2, 3, 4, 5);
            ////Sum(1, 2);
            ////Sum(1);
            //Sum();

            //string a = "A";
            //string b = "B";

            //Console.WriteLine($"Before method: {a} {b}");

            //void Flip(string first, string second)
            //{
            //    string temp = first;
            //    first = second;
            //    second = temp;
            //}

            //Flip(a, b);
            //Console.WriteLine($"After method: {a} {b}");


            //int x = 10, y = 1;
            //int s;
            //void Add(int first, int second, out int s)
            //{
            //    s = first + second;
            //}


            //<accessor> <return type> <name>( type1, type2)
            //{
            //    // statements
            //}
        }

        public static void WriteLineWithOwner(string value, string owner = "NONE", string consumer = "NONE")
        {
            Console.WriteLine("{0}{1}", owner, value);
        }

        public static void WriteLineWithOwner(int value, string owner = "NONE")
        {
            Console.WriteLine("{0}{1}", owner, value);
        }

        public static void WriteLineWithOwner(decimal value, string owner = "NONE")
        {
            Console.WriteLine("{0}{1}", owner, value);
        }
    }
}
