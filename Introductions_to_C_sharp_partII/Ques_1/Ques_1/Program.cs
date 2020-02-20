//Implementation of abstract class
using System;

namespace Ques_1
{
    abstract class AreaClass
    {
        abstract public int Area(); // declaring method area as abstract 
        public void print()   //non abstract method in abstract class
        {
            Console.WriteLine("hi");
        }
    }
 
    class Square : AreaClass //abstract class inherited in square class 
    {
        int side = 0;

        public Square(int n) //constructor
        {
            side = n;
        }

        
        public override int Area() // a bstract method is inherited here 
        {
            return side * side;
        }
    }
    class Rectangle : AreaClass //abstract class inherited in square class 
    {
        int length = 0;
        int breath = 0;

        public Rectangle(int l, int b) //constructor
        {
            length = l;
            breath = b;
        }


        public override int Area() // abstract method is inherited here 
        {
            return length*breath ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square obj = new Square(10);
            int result=obj.Area();
            Console.WriteLine("Area of square is =" +result);
            obj.print();

            Rectangle obj1 = new Rectangle(10,20);
            int result1=obj1.Area();
            Console.WriteLine("Area of rectangle is = "+result1);
            obj1.print();

        }
    }
}
