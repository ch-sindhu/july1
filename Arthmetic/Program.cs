using System;

namespace Arthmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            int num2 = 25;
            int result;
            result = num1 + num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 - num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 * num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 % num2;
            Console.WriteLine("Value is {0}", result);
            
            Console.ReadLine();



        }
    }
}
