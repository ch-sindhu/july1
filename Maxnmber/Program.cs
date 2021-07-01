using System;

namespace Maxnmber
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxNo;
            Console.WriteLine("Enter a no");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a no");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                MaxNo = a;
            }
            else
            {
                MaxNo = b;
            }
            Console.WriteLine("Maximum number is: " + MaxNo);
        }
    }
}
