using System;

namespace Arithmetic1
{
    class Program
    {
        static void Main(string[] args)
        {
            int add, sub, mul;
            float div;
            int a = 50;
            Console.Write("Enter first number\t\t");
            int  b = Convert.ToInt32(Console.ReadLine());
            add = a+ b;
            Console.WriteLine("Addition is {0}", add);
            sub = a - b;
            Console.WriteLine("Subtraction\t\t{0}", sub);
            mul = a * b;
            Console.WriteLine("Multiplication\t\t{0}", mul);
            div = (float)a / b;
            Console.WriteLine("Division\t\t{0}", div);

        }
    }
}
