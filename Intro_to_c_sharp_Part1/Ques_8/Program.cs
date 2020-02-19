using System;

namespace Ques_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the value till which u want to print the table: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("table of " + i + " is :");
                for (int j=1; j <= 10; j++)
                {
                    Console.Write(" " +4i + "*" +j+ "=" +(j * i)+ " " );
                }
                Console.WriteLine("\n");
            }
        }
    }
}
