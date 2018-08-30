using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial");
            Console.WriteLine("Enter the number :");

            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            /* 
            for(int i=number ; i>=1; i--)
            {
                result *= i;
            }
            */

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine("Factorial of {0} is {1}",number,result);

            Console.ReadLine();
        }
    }
}
