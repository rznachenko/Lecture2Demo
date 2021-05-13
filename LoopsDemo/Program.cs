using System;

namespace LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Guess a number from 1 to 10");
            while (i < 5)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > -1 && number < 3)
                {
                    Console.WriteLine("Freezing");
                    i++;
                    continue;
                }

                if (number < 7)
                {
                    Console.WriteLine("Cold");
                    i++;
                    continue;
                }

                if (number > 7)
                {
                    Console.WriteLine("Hot!");
                    i++;
                    continue;
                }

                if (number == 7)
                {
                    Console.WriteLine("you won");
                    break;
                }
            }
            //do
            //{
                   // statements
            //}
            //while (condition)

            //while (condition)
            //    //statements

            for (int k = -10; k <= 10; k++)
            {
                if (k > 0) break;

                Console.Write(k + " ");
            }
            //for (intiz; condition; iteration) 
                // statements

            //int age = 18;
            //bool hasPassport = false;
            //switch (age)
            //{
            //    case 1:
            //        break;
            //    case 18 when hasPassport:
            //        break;
            //    default:
            //        break;
            //}

            //if (condition)
            //{
            //    // statements
            //}
            //else
            //{
            //    // statements
            //}
        }
    }
}
