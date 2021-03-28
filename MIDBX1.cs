using System;

namespace MIDBX
{
    class Program
    {
        static void Main(string[] args)
        {
			bool gameStart = true;
			Console.WriteLine("Enter box1");
			Console.WriteLine("Enter box2");
			Console.WriteLine("Enter box3");
			int b1 = int.Parse(Console.ReadLine());
			int b2 = int.Parse(Console.ReadLine());
			int b3 = int.Parse(Console.ReadLine());
			while (gameStart == true)
			{
				Console.WriteLine("A Choose box");
				Console.WriteLine("(1) Box1 (2) Box2 (3) Box 3");
				int Abox = int.Parse(Console.ReadLine());
				Console.WriteLine("A Enter amount");
				int Aamount = int.Parse(Console.ReadLine());
				switch (Abox)
				{
					case 1:
						b1 = b1 - Aamount;
						break;
					case 2:
						b2 = b2 - Aamount;
						break;
					case 3:
						b3 = b3 - Aamount;
						break;
					default:
						Console.WriteLine("Fail");
						break;
				}
				if (b1 <= 0 & b2 <= 0 & b3 <= 0)
				{
					Console.WriteLine("B is Winner");
					gameStart = false;
					return;
				}
				Console.WriteLine("B Choose box");
				Console.WriteLine("(1) Box1 (2) Box2 (3) Box 3");
				int Bbox = int.Parse(Console.ReadLine());
				Console.WriteLine("B Enter amount");
				int Bamount = int.Parse(Console.ReadLine());
				switch (Bbox)
				{
					case 1:
						b1 = b1 - Bamount;
						break;
					case 2:
						b2 = b2 - Bamount;
						break;
					case 3:
						b3 = b3 - Bamount;
						break;
					default:
						Console.WriteLine("Fail");
						break;
				}
				if (b1 <= 0 & b2 <= 0 & b3 <= 0)
				{
					Console.WriteLine("A is Winner");
					gameStart = false;
					return;
				}
			}
		}
    }
}