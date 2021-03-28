using System;

namespace MIDEX
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            Console.Write("input number a : ");
            Console.Write("input number b : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            while (x != y)
            {
                if (x < y) 
                { 
                    x = x + a; 
                }
                else 
                { 
                    y = y + b; 
                }
                Console.Write(x);
            }

            Console.ReadLine();
        }
    }
}
