//What is virtual method in c# ? 
using System;

namespace Ques_5
{
    class test
    {
        public int num1,num2,num3;
        public test()
        {
            num1 = 10;
            num2 = 10;
            num3 = 10;
        }
        public test(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            
        }
        public test(int num1,int num2,int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public virtual void addition()
        {
            Console.WriteLine("\n");
            Console.WriteLine("I'm in virtual function of base class");
            Console.WriteLine("\n");
        }
    }
    class testing1 :test
    {   
        public testing1(int num1,int num2) : base(num1, num2)  //calling parameterized constructor of base class
        {

        }
        public override void addition() //overriding virtual function of base class
        {
            Console.WriteLine("\n");
            int result = num1 + num2;
            Console.WriteLine("We are in derive class annd here virtual function is overridden");
            Console.WriteLine("The result of addition is: " + result);
            Console.WriteLine("\n");
        }


    }
    class testing2 : test
    {
        public testing2(int num1, int num2,int num3) : base(num1, num2,num3) //calling parameterized constructor of base class
        {

        }
        public override void addition()  //overriding virtual function of base class
        {
            Console.WriteLine("\n");
            int result1 = num1 + num2+num3;
            Console.WriteLine("We are in derive class annd here virtual function is overridden");
            Console.WriteLine("The result of addition is: " + result1);
            Console.WriteLine("\n");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("to check you want to write 3 numbers");
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number :");
            num3 = Convert.ToInt32(Console.ReadLine());
            test obj2 = new test();   
            obj2.addition(); // calling virtual finction of base class
            testing1 obj = new testing1(num1,num2);
            obj.addition(); // calling overriden function of derived class
            testing2 obj1 = new testing2(num1, num2, num3);
            obj1.addition();  // calling overriden function of derived class

        }
    }
}
