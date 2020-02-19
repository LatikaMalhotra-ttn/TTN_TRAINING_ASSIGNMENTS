//Write a program to reverse your full name without using an inbuilt function?

using System;

namespace Ques_7
{
    class rev_string
    {
        string str;
        public rev_string(string str)   //Initilaizing string
        {
            this.str = str;
        }
        public void fun_rev_string (string str)  //function to reverse a string
        {
            int len = (str.Length)-1 ;     //cal length of string
            char[] RevString = new char[len+1];       //declaring an array of char type in which reverse string will be stored
            int index = 0;
            for(int i =len; i>=0; i--)   // loop to reverse a string and store it in new array
            {
                RevString[index] = str[i];
                index++;
            }
            Console.WriteLine("\nReverse string is:");
            for(int i = 0; i <= len; i++)         //print the reverse string
            {
                Console.Write(RevString[i]);
            }
            Console.WriteLine("\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                string str;
                Console.WriteLine("Enter string u want to reverse: ");
                str = Console.ReadLine();
                rev_string obj = new rev_string(str);
                obj.fun_rev_string(str);
                Console.WriteLine("Do u want to check for other string ?[Enter 'y' or 'Y' for yes and any other key to exit");
                choice =Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice == 'Y');
        }
    }
}
