using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{

		static void Main()
		{
			//Условные операторы
			System.Console.Write("Введите целое число: ");
			int num = Convert.ToInt32(Console.ReadLine());
			if (num < 100 && num > 50){
				System.Console.WriteLine("Число бльше 50 и меньше 100");
			}else if (num > 0 && num <50) {
				System.Console.WriteLine("Число бльше 0 и меньше 50");
			}else {
				System.Console.WriteLine("Число неопределено");
			}

		}
	}
}
