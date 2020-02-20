//method overriding

using System;

namespace Ques2_overriding
{
    class test1
    {
        public virtual void fun()  //making method virtual which indicates that it can be overriden
        {
            Console.WriteLine("Hi, I'm in base class");
        } 
    }
    class test2:test1
    {
        public override void fun() //overriding fun method which was declared virtual in its base class 
        {
            Console.WriteLine("Hi, I'm in derive class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test1 obj = new test1(); // obj of base class
            obj.fun(); // calling method which is in base class
            test2 obj1 = new test2(); // obj of derived class 
            obj1.fun(); //calling overriding method which is in derive class
        }
    }
}
