using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{

		static void Main()
		{
			int[] mas = new int[6] { 3, 5, 2, 8, 3, 2 };
			System.Console.Write("Введите число: ");
			int x = Convert.ToInt32(Console.ReadLine());
			bool target = false;
			foreach (int elem in mas)
			{
				if (x == elem)
				{
					System.Console.WriteLine($"Да есть такая цифра {elem}");
					target = true;
					break;
				}

			}
			if (target == false)
				System.Console.WriteLine("Такого числа нет");
		}
	}
}
