using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("About which language do you want to know information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
            string line = Console.ReadLine();
            byte languageValue;
            if (!byte.TryParse(line, out languageValue))
            {
                Console.WriteLine("Please follow the instructions and try again");
            }

            Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
            Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
            Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");

            //int integer = 1;
            ////int a, b, c = 2;
            //double dd = 1.5D;
            //float f = 1.3F;
            //char symbol = 'x';
            //string text = "Some text";
            //char textSymbol = text[0];

            //decimal first = 10M;
            //decimal second = 10.2M;
            //decimal sum = first + second;

            //Console.WriteLine("Sum " + sum);
        }

        public enum Language : byte
        {
            English = 1,
            Spanish = 2,
            Ukrainian = 3
        }
    }
}
