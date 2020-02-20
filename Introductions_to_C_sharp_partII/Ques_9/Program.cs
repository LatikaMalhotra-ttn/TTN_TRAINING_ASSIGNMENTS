//ques given by sir in session to check different ways in which object can be formed

using System;

namespace Ques_9
{
    class A
    {
        public A()
        {
            Console.WriteLine("default constructor of A class");
        }
        public A(int x,int y)
        {
            Console.WriteLine("paramaterized constructor of A class");
        }
        static A()
        {
            Console.WriteLine("static constructor of A class");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("default constructor of B class");
        }
        public B(int x)
        {
            Console.WriteLine("parametrized constructor of B class");
        }
        static B()
        {
            Console.WriteLine("static constructor of B class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();  //this will first call static constructor of B the this will call static constructor 
                              //of A ,then it will call default constructor of A and then default constructor of B
            Console.WriteLine("\n");

            B obj1 = new B(10);  //this will first call static constructor of B the this will call static constructor of A
                                 //then it will first call default constructor of A then parametrized constructor of B is called 
            Console.WriteLine("\n");

            //B obj3 = new A();   -> this statement will give error

            A obj4 = new B(); //this will first call static constructor of B the this will call static constructor of A
                              //then ,first default constructor of a is called then default constructor of b is called

            // B obj7 = new A(10, 20);   -> this will raise error
        }                             
    }
}
