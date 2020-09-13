using System;
using System.Runtime.InteropServices;

namespace NumbersHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            fromDecimal(9248, 16);
        }

        static void printFormattedNums(int num, int answer, int divisor, int remainder)
        {
            Console.WriteLine("{0, 6}", divisor);
            Console.WriteLine("{0, 5} {1, 1} {2, 2}",num, "|", answer);
            Console.WriteLine("{0, 6}", remainder);
            Console.WriteLine("===============================");
        }
        static int convertFromDecimal(int num, int divisor)
        {
            if(num > divisor)
            {
                int answer = num / divisor;
                int remainder = num % divisor;
                printFormattedNums(num, answer, divisor, remainder);
                convertFromDecimal(answer, divisor);
            }
            if(num == divisor)
            {
                printFormattedNums(num, 1, divisor, 0);
            }
            return num;
        }
        static void fromDecimal(int num, int divisor)
        {
            convertFromDecimal(num, divisor);
            Console.WriteLine(  Convert.ToString(num, divisor));
        }
    }
}
