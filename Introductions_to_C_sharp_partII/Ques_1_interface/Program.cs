//implmentation of interface
using System;

namespace Ques_1_interface
{
    interface test_interface
    {
        void test(); // interface method
    }

    class test1 : test_interface // class inheriting interface
    {
        public void test()  // defination of method of interface
        {
            Console.WriteLine("hi , i'm in test1 class ");
        }
    }
    class test2 : test_interface  // class inheriting interface
    {
        public void test()  // defination of method of interface
        {
            Console.WriteLine("hi , i'm in test2 class ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test1 obj = new test1();
            obj.test();
            test2 obj1 = new test2();
            obj1.test();
        }
    }
}
