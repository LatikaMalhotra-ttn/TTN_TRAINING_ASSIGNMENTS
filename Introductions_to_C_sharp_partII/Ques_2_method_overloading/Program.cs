//method overloading

using System;

namespace Ques_2_method_overloading
{
    class Addition
    {
        public void add(int num1,int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine("Adding 2 numbers, the result is : " + num3);
        }
        public void add(int num1, int num2,int num3)
        {
            int num4 = num1 + num2+num3;
            Console.WriteLine("Adding 3 numbers, the result is:" + num4);
        }
        public void add(int num1, int num2,int num3,int num4)
        {
            int num5= num1 + num2 +num3 +num4;
            Console.WriteLine("Adding 4 numbers, the result is: " + num5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition obj = new Addition();
            obj.add(2, 4);
            obj.add(2, 3, 4);
            obj.add(2, 3, 4, 5);
        }
    }
}
