using System;

namespace Ques_6
{
    //below class show use of public access modifier
    class Student
    {
        public int rollNo;   //public member
        public string name;  //public member

        public Student(int r, string n)  //public constructor to initialize members
        {
            rollNo = r;
            name = n;
        }

        public int getRollNo() //public method
        {
            return rollNo;
        }
        public string getName()  // public methods
        {
            return name;
        }
    }

    //below class show use of protected access modifier
    class test
    {
        protected int x; // member is declared as protected

        public test() //initialize members through constructor
        {
            x = 10;   
        }
    }

    class inherit_test : test
    {

        public int getX()  //members of inherit_test can access protected members of test
        {
            return x;
        }
    }

    //declared an internal class 
    internal class testing
    {

        int test;
        public void setData(int t)
        {
            this.test = t;
        }
        public void displayData()
        {
            Console.WriteLine("Checked variable has data = {0}", test);
        }
    }

    //below class is used to explain use of private access modifier
    class Parent
    {
        private int value;  //member is declared as private  
        public void setValue(int v) //private members can only be accessed within the class in which it is declared
        {
            value = v;
        }
        public int getValue()
        {
            return value;
        }
    }
    class Child : Parent
    {

        public void showValue()
        {
            //trying to access private member from another class
            // Console.WriteLine( "Value = " + value );  ->gives an error
            
        }


        

    }


    //below class show the use of private-protected
    class Parent1
    {

        private protected int value;  //member is declared as private-protected

        public void setValue(int v)   // value is Accessible only inside the class 
        {
            value = v;
        }
        public int getValue()
        {
            return value;
        }
    }

    class Child1 : Parent1
    {

        public void showValue()
        {

            Console.WriteLine("Value = " + value); // trying to access value inside derive class->whuch is accessable
        }
    }



    //below class show the use of protected internal
    class check
    {

        protected internal int val;   // Declaring member as protected internal
    }
    class ABC
    {
        public void testAccess()  //trying to access member in another class
        {

            check obj3 = new check();   // Member value is Accessible 
            obj3.val = 12;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // below statements are showing use of public access modifier
            Student S = new Student(1, "latika");  //creating an object
            Console.WriteLine("Roll number: {0}", S.rollNo); //displaying public members directly
            Console.WriteLine("Name: {0}", S.name);  //displaying public members directly
            Console.WriteLine("Roll number: {0}", S.getRollNo()); //displayiing members using function
            Console.WriteLine("Name: {0}", S.getName());   //displayiing members using function
            Console.WriteLine("\n");




            // below statements are showing use of protected access modifier
            inherit_test obj2 = new inherit_test();
            Console.WriteLine("Value of x is : {0}", obj2.getX()); // displaying protected member of test class
            Console.WriteLine("\n");




            //making object of class testing in separate class but within same assembly
            testing c = new testing();
            c.setData(2); //accessing in classs program
            c.displayData();
            Console.WriteLine("\n");



            //making obj of class Parent in which we have parent member 
            Parent obj = new Parent();
            // obj.value = 5;    ->gives an error
            obj.setValue(4);   // used public function to access value of private member
            Console.WriteLine("Value = " + obj.getValue());




            //making obj of class parent1 in whuch we have private-protected members
            Parent obj1 = new Parent();
            // obj.value = 5;     ->will gives an error    
            obj.setValue(4);    //use public funation to assign and use value of the member 'value'
            Console.WriteLine("Value = " + obj.getValue());



        }


    }
}

