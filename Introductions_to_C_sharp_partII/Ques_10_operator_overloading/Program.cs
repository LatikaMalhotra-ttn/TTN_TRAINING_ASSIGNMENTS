using System;

namespace Ques_10_operator_overloading
{
    class Rectangle
    {
        private double length;
        private double breadth;
        public double getarea()
        {
            return length * breadth;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public static Rectangle operator +(Rectangle b, Rectangle c) //overloading + operator to add two objects
        {
            Rectangle rec = new Rectangle();
            rec.length = b.length + c.length;
            rec.breadth = b.breadth + c.breadth;
            return rec;
        }
        public static bool operator ==(Rectangle obj1, Rectangle obj2)
        {
            bool status = false;
            if (obj1.length == obj2.length && obj1.breadth == obj2.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Rectangle obj1, Rectangle obj2)
        {
            bool status = false;

            if (obj1.length == obj2.length || obj1.breadth == obj2.breadth)
            {

                status = true;
            }
            return status;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj1 = new Rectangle();
            Rectangle obj2 = new Rectangle();
            Rectangle obj3 = new Rectangle();
            Rectangle obj4 = new Rectangle();

            obj1.setLength(2.0);
            obj1.setBreadth(2.0);

            obj2.setLength(3.0);
            obj2.setBreadth(4.0);

            obj3.setLength(2.0);
            obj3.setBreadth(4.0);

            obj4.setLength(2.0);
            obj4.setBreadth(4.0);

            Console.WriteLine("Rectangle 1: {0}", obj1.ToString());
            Console.WriteLine("Rectangle 2: {0}", obj2.ToString());

            double area = obj1.getarea();
            Console.WriteLine("Volume of Rectangle1 : {0}", area);

            double area1 = obj2.getarea();
            Console.WriteLine("Volume of rectangle2 : {0}", area1);

            double area2 = obj3.getarea();
            Console.WriteLine("Volume of Rectangle 3 : {0}", area2);

            obj3 = obj1 + obj2;
            Console.WriteLine("Rectangle 3: {0}", obj3.ToString());

            if (obj1 != obj2)
                Console.WriteLine("obj1 is not equal to obj2");
            else
                Console.WriteLine("obj1 is not greater or equal to obj2");
            obj4 = obj3;

            if (obj3 == obj4)
                Console.WriteLine("obj3 is equal to obj4");
            else
                Console.WriteLine("obj3 is not equal to obj4");

        }
    }
}
