//Write a program to for parameterised constructor and call the same from derived call ?

using System;

namespace Ques_7
{
    class shape   //base class in which all fields are called and initaialized 
    {
        public int length;
        public int breath;
        public int height;
        public double radius;
        public int side;
        public shape()
        {
            length = 0;
            breath = 0;
            height = 0;
            radius = 0;
            side = 0;
        }
        public shape(int length, int breath)
        {
            this.length = length;
            this.breath = breath;
        }
        public shape(int side)
        {
            this.side = side;
        }
        public shape(int length, int breath, int height)
        {
            this.length = length;
            this.breath = breath;
            this.height = height;
        }
        public shape(double radius)
        {
            this.radius = radius;
        }
        public virtual void area()
        {
            Console.WriteLine("we r in base class now, defination will be given in derive classes");
        }
    }
    class Rectangle: shape
    {
        public Rectangle(int l,int b): base(l,b)  //using this constructor we are calling constructor of base class and initializing fields
        {
            
        }
        public override void area()
        {
            int result = this.length * this.breath;
            Console.WriteLine("area of rectangle is : " + result);
        }
    }
    class Square : shape
    {
        public Square(int side) : base(side)  //using this constructor we are calling constructor of base class and initializing fields
        { 
        }
       public override void area()
        {
            int result = this.side* this.side;
            Console.WriteLine("area of square is : " + result);
        }
    

    }
    class Circle : shape
    {
        public Circle(double radius) : base(radius)  //using this constructor we are calling constructor of base class and initializing fields
        {

        }
        public override void area()
        {
            double result = (3.14 * this.radius * this.radius);
            Console.WriteLine("area of circle is : " + result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char choice1='Y';
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. calculate are of rectangle?");
                Console.WriteLine("2. calculate are of square?");
                Console.WriteLine("3. calculate are of square?");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nWe will calculate area of rectangle");
                        Console.Write("enter length of rectangle: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("enter breath of rectangle: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Rectangle rect_obj = new Rectangle(num1, num2);  // making object of derive class but initializing through base class
                        rect_obj.area();
                        break;
                    case 2:
                        Console.WriteLine("\nWe will calculate area of square");
                        Console.Write("enter side of square: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Square square_obj = new Square(num3);   // making object of derive class but initializing through base class
                        square_obj.area();
                        break;
                    case 3:
                        Console.WriteLine("\nWe will calculate area of circle");
                        Console.Write("enter radius of circle: ");
                        double num4 = Convert.ToDouble(Console.ReadLine());
                        Circle circl_obj = new Circle(num4);  // making object of derive class but initializing through base class
                        circl_obj.area();
                        break;
                    default :
                        Console.WriteLine("you entered wrong choice");
                        break;

                }

                Console.Write("\nDo you want to check other methods ?[enter'y' or 'Y' for yes ]:  ");
                choice1 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n");
                
            } while (choice1 == 'y' || choice1 == 'Y');

        }
    }
}
