using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{

		static void Main()
		{
			//Математические действия
			/*
			Console.Write("Введите целое число: ");
			int int_num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Целое число: " + int_num);
			
			*/
			/*
			Console.Write("Введите число с плавающей запятой: ");
			//user_input = Convert.ToDouble(Console.ReadLine());
			float user_input = float.Parse(Console.ReadLine());
			Console.WriteLine("Переменная: " + user_input);
			

			float result = user_input + 10f;

			Console.WriteLine("Переменная: " + result);
			*/
			/*
			System.Console.WriteLine(Math.PI); //Сокращенно "cw + Tub"
			System.Console.WriteLine(Math.Abs(-20)); //Модуль
			System.Console.WriteLine(Math.Ceiling(4.11f));
			System.Console.WriteLine(Math.Floor(4.99f));
			System.Console.WriteLine(Math.Round(4.5f));

			System.Console.WriteLine(Math.Min(4, 5));
			System.Console.WriteLine(Math.Max(4, 5));

			System.Console.WriteLine(Math.Pow(2, 10));
			*/

			System.Console.WriteLine("Введите радиус круга: ");
			double radius = Convert.ToDouble(Console.ReadLine());
			double area = Math.PI * Math.Pow(radius, 2);
			System.Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, Math.Round(area, 2));


		}
	}
}
