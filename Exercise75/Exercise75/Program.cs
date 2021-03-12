using System;

namespace Exercise75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var userNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your square root is: " + SquareRoot(userNum, 0));
        }

        public static int SquareRoot(int number, int rt)
        {
            if (rt > number / 2)
            {
                return -1;
            }
            else if (rt * rt == number)
            {
                return rt;
            }
            else
            {
                rt++;
                return SquareRoot(number, rt);
            }

        }
    }
}
