//What are the different ways a method can be overloaded ?
using System;

namespace Ques_4
{
    class Program
    { 
        public int Add(int a, int b)  
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c) //1. by changing number of parameters
        {
            int sum = a + b + c;
            return sum;
        }
        public double Add(double a,double b) //2.by changing data type of parameters
        {
            double sum = a + b ;
            return sum;
        }
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name : " + name + ", " + "Id : " + id);

        }
        public void Identity(int id, String name) //3.By changing the order of the parameter
        {

            Console.WriteLine("Id : " + id + "," +" Name : " + name );

        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            int result=obj.Add(5, 10);
            Console.WriteLine("Result of calling add function with 2 parameters = " + result);
            int result1 = obj.Add(5, 10,11);
            Console.WriteLine("Result of calling add function with 3 parameters = " + result1);
            double result2 = obj.Add(1.0,2.0);
            Console.WriteLine("Result of calling add function with different types of parameters = " + result2);
            obj.Identity(1,"latika");
            obj.Identity("latika",1); //when changing the order of parameter function is called
        }
    }
}
