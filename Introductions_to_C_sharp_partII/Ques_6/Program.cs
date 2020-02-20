//How to preventing Derived class from overriding virtual members?

using System;

namespace Ques_6
{
    sealed class testing  //since we have made this class sealed,therefore no class can inherit it.
    {
        public void fun()
        {
            Console.WriteLine("hi,i'm in sealed class");
        }

    }
    class test
    {
        public virtual void fun1()
        {
            Console.WriteLine("hi,i'm in test class in virtual function");
        }
    }
    class test1 : test
    {
        sealed public override void fun1() // since we have this sealed .therefore, it cannot be overriden in further classes
        {
            Console.WriteLine("hi,i'm in derive class of base class in virtual function ");
        }
        public void fun3()
        {
            Console.WriteLine("hi,i'm in derive class and this method can be overriden ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            testing obj = new testing(); //sealed class obj is created 
             obj.fun();  // sealed class function is called
            test obj1 = new test(); 
            obj1.fun1(); //base class function is called
            test1 obj2 = new test1();
            obj2.fun1(); // derive class function is called and is made sealed so that it cannot be overriden
            obj2.fun3();
        }
    }
}
