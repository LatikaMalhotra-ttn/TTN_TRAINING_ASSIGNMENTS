//Write a program to show the difference between Static & Instance Member?

using System;

namespace Ques_1
{
    class Circle
    {
        static float _PI ; // made this static because PI value will reamin same for all the object. So, no need to allocate memory for it again and again
        int _Radius; // made this instance member because its value can be different for different objects  

        static Circle() // made static constructure to initialize static members
        {
            _PI = 3.14F;
        }

        public Circle(int Radius) //made static constructure to initialize instance members
        {
            this._Radius = Radius;
        }
        
        public float CalcuateArea()
        {
            return Circle._PI * this._Radius * this._Radius;


        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter radius");
            int num = Convert.ToInt32(Console.ReadLine());
            Circle C1 = new Circle(num); 
            float Area = C1.CalcuateArea();
            Console.WriteLine("Area = {0}", Area);
        }
    }
    
}
