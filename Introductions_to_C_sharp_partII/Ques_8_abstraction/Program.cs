//Write a program to explain encapsulation and abstraction ?
using System;

namespace Ques_8_abstraction
{
    abstract class Shape   //abstract class
    {
        public abstract int area();  //abstract method
    }

    class Square : Shape  //shape class is inherited 
    {

        private int side; //private data member

        public Square(int x = 0) //method of square class 
        {
            side = x;
        }
        public override int area()  //overriding of abstract method of shape ,class using the override keyword
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Square(4);// object created
            double result = sh.area(); // calling the method
            Console.Write("{0}", result); // displaying result
        }
    }
}
