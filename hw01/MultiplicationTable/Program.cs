using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Enter the number :");
            
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i =1;i<=100;i++){
                Console.WriteLine("{0} x {1} = {2}",number,i,number*i);
            }


            Console.ReadLine();

        }
    }

}
