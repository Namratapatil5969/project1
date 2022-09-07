using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get two numbers from user and perform add, sub, mul and div using switch case
            Console.WriteLine("Enter the two number");
            int a, b;
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 for add");
            Console.WriteLine("2 for sub");
            Console.WriteLine("3 for Multiply");
            Console.WriteLine("4 for Divide");
            int num= Convert.ToInt32(Console.ReadLine());
            switch(num)

            {
                case 1:

                    Console.WriteLine($"Addition is{a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Sub is {a-b}");
                    break;
                case 3:
                    Console.WriteLine($"Mul is {a*b}");
                    break;
                case 4:
                    Console.WriteLine($"Div is {a / b}");
                    break;

                    default:
                    Console.WriteLine("Wrong input");
                    break;
            }


        }

    }
}
