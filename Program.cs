using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            do
            {
                Menu.menu();

                choice = Convert.ToInt32 (Console.ReadLine());
                //Console.WriteLine("Your choice is " + choice);

                double num1 = 0;
                double num2 = 0;

                if (choice <=4)
                { 
                    Console.Write("\nnumber 1 =  ");
                    num1 = Convert.ToDouble (Console.ReadLine());
                    Console.Write("number 2 =  ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }

                if (choice == 1 )
                {
                    Console.WriteLine("Sum =" + Operations.addition(num1, num2));
                }
                
                else if (choice == 2)
                {
                    Console.WriteLine("Difference =" + Operations.substraction(num1, num2));
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Product =" + Operations.multiplication(num1, num2));
                }

                else if (choice == 4)
                {
                    Console.WriteLine("Quotient =" + Operations.division(num1, num2));
                }
            } while (choice <=4);
        }
    }
}