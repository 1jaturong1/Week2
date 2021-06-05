using System;

namespace การบ้าน6._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Mealtime,hungrytime;
            Console.Write("Input Mealtime");
            Mealtime = double.Parse(Console.ReadLine());
            hungrytime = double.Parse(Console.ReadLine());
            if (Mealtime >= 0 && Mealtime <= 24)
            {
                hungrytime = Mealtime + 4;
            }
            if (hungrytime <= 6)
            {
                Console.WriteLine("hungrytime");
            }
            else
            {
                Console.WriteLine("Eat now!!!");
            }
            Console.ReadLine();
        }
    }
}
