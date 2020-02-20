using System;

namespace Ques_8
{
    public class Employee
    {

        private String EmpName;  //private field declared they can only be accessed by public method of class
        private int EmpAge;   //private field declared they can only be accessed by public method of class

        public String Name  //using accessor to get and set value of private members
        { 
            get
            {
                return EmpName;
            }
            set
            {
                EmpName = value;
            }
        } 
        public int Age   //using accessor to get and set value of private members
        {
            get
            {
                return EmpAge;
            }
            set
            {
                EmpAge = value;
            }
        }
        private void fun()  //making method private which canniot be directly inherited
        {
            Console.WriteLine("Hi i'm in private method and from here we are accessing private fields");
            Console.WriteLine("my name is: " + EmpName + "  and my age is: " + EmpAge);
        }
        public void fun2()
        {
            fun(); // calling private method of the same class
            Console.WriteLine("we are now in public method");
        }
             
    }
    class Program
    {
        static void Main(string[] args)
        {
       
            Employee obj = new Employee(); //object created
            obj.Name = "Latika"; //calling accessor of property name and passing "latika"
            obj.Age = 21; //calling accessor of property age and passing "21"
            obj.fun2();
        }
    }
}
