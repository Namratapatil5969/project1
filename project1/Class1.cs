using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int n1 = 15, n2 = 20;
            int result = n1 + n2;
            int multiply = n1 * n2;
            int divide = n1 / n2;
            int substract = n2 - n1;
            int mod = n1 % n2;
            Console.WriteLine($"Addition is {result}");
            Console.WriteLine($"Multiplication is {multiply}");
            Console.WriteLine($"Division is {divide}");
            Console.WriteLine($"Substraction is {substract}");
            Console.WriteLine($"Mod is {mod}");

        }

    }
}
