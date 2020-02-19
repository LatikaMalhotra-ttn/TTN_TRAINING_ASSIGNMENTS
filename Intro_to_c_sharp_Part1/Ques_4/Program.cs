//Write a program to define the boxing and unboxing concepts?
using System;

namespace Ques_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int test = 23;  // initializing test variable
            object obj = test;  // boxing
            int i = (int)obj;     // unboxing
            test = 864;   //changing value of test
            Console.WriteLine("value type value of test is: "+ test);
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
        }
    }
}
