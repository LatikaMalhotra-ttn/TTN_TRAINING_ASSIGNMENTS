// What would happen in case if the inherited interfaces have conflicting method names?

using System;

namespace Ques_3
{
    interface test1
    {
        void print();
        void fun();
    }
    interface test2
    {
        void print();
        void fun();
    }

    class Program : test1, test2

    {

        void test1.print()   //if we write this function as "public test1.print()"then it will raise error
                             //therefore we need to remove Public modifier from the methods, because it implement
                             // by using interface name to differentiate same method by their interface.

        {
            Console.WriteLine("test1 Interface function");
        }
        void test2.print()
        {
            Console.WriteLine("test2 Interface function");
        }
        public void fun() //if we don't specify the interface name and try to define it then the defination is same for both the interface
        {
            Console.WriteLine("this function defination is comman for both interface");
        }
        static void Main(string[] args)

        {
            Program obj2 = new Program();
            obj2.fun();
            test1 obj = new Program();
            obj.print(); //this will call the function defination which is particular to test1 interface
            obj.fun(); // since we have not mentioned the interface name while defining the fun.so it would be comman for both interface
            test2 obj1 = new Program();
            obj1.print(); //this will call the function defination which is particular to test2 interface
            obj1.fun();  // since we have not mentioned the interface name while defining the fun.so it would be comman for both interface
            
        }

    }
}
