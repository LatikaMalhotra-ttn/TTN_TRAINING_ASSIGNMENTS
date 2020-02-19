//Write a program to find the leap year?
using System;

namespace Ques_2
{
    class Leap_year
    {
        int year;
        public Leap_year(int year)
        {
            this.year=year;
        }
        public void cal_leapyear() //this function wheater year is leap or not.
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                Console.WriteLine("{0} is a leap year", year);
            else
                Console.WriteLine("{0} is not a leap year", year);
        }
    }
    class Program
    {
        static void Main(string[] args)

        {
            char choice;
            do
            {
                int num =0;
                Console.WriteLine("Enter the year u wan to check");
                //Console.WriteLine("check");
                num = Convert.ToInt32(Console.ReadLine());
                Leap_year L1 = new Leap_year(num);
                L1.cal_leapyear();
                Console.WriteLine("\n");
                Console.WriteLine("do u want to check for other year? [Press Y or y to continue ans any other key ]");
                choice = Convert.ToChar(Console.ReadLine());

                
            } while (choice == 'Y' || choice == 'y');
            
        }
    }
}
