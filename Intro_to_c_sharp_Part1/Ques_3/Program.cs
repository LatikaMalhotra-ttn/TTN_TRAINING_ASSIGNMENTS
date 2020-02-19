// Write a program To find Constant & vowel using both Switch case & if_else?
using System;

namespace Ques_3
{
    class Program
    {
        
        public class vowel_consonent
        {
            char ch;
            public vowel_consonent(char ch)
            {
                this.ch = ch;
            }
            public void if_else_vowel_consonent()      // mehod to check wheather an alphabet is a vowel or consonent using if_else
            {
                
                
                int i = ch;
                if (i >= 48 && i <= 57)
                {
                    Console.Write("You entered wrong data");
                }
                else
                {
                    if(ch == 'a' || ch == 'A')
                    {
                        Console.WriteLine("u entered a vowel");
                        
                    }
                    else if(ch == 'e' || ch=='E')
                    {
                        Console.WriteLine("u entered a vowel");
                    }
                    else if (ch == 'i' || ch == 'I')
                    {
                        Console.WriteLine("u entered a vowel");
                    }
                    else if (ch == 'o' || ch == 'O')
                    {
                        Console.WriteLine("u entered a vowel");
                    }
                    else if (ch == 'u' || ch=='u')
                    {
                        Console.WriteLine("u entered a vowel");
                    }
                    else
                    {
                        Console.WriteLine("u entered a consonent");
                    }
                }
               
            }
            public void switch_vowel_consonent()      // mehod to check wheather an alphabet is a vowel or consonent using switch
            {


                int i = ch;
                if (i >= 48 && i <= 57)
                {
                    Console.Write("You entered wrong data");
                }
                else
                {
                    switch (ch)
                    {
                        case 'a':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'e':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'i':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'o':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'u':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'A':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'E':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'I':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'O':
                            Console.WriteLine("U entered a vowel");
                            break;
                        case 'U':
                            Console.WriteLine("U entered a vowel");
                            break;
                        default:
                            Console.WriteLine("U entered a consonent");
                            break;
                    }
                }

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Menu :-");
            Console.WriteLine("1.To check wheather an alphabet is vowek or consonent using if else  :-");
            Console.WriteLine("2.To check wheather an alphabet is vowek or consonent using switch  :-");
            Console.Write("Enter your choice: ");
            int choice3 = Convert.ToInt32(Console.ReadLine());
            char again;
            do
            {

                switch (choice3)
                {
                    case 1:
                        Console.Write("Input an Alphabet : ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        vowel_consonent A1 = new vowel_consonent(ch);
                        A1.if_else_vowel_consonent();
                        Console.WriteLine("Do u want to checvk for another alphabet {Enter 'y' ,'Y' ,'n' or 'N'}");
                        again = Convert.ToChar(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("Input an Alphabet : ");
                        char ch1 = Convert.ToChar(Console.ReadLine());
                        vowel_consonent A2 = new vowel_consonent(ch1);
                        A2.switch_vowel_consonent();
                        Console.WriteLine("Do u want to checvk for another alphabet {Enter 'y' ,'Y' ,'n' or 'N'}");
                        again = Convert.ToChar(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Wrong choice entered");
                        Console.WriteLine("Do u want to checvk for another alphabet {Enter 'y' ,'Y' ,'n' or 'N'}");
                        again = Convert.ToChar(Console.ReadLine());
                        break;

                }
            } while (again == 'y' || again == 'Y');
        }
            
    }
}
