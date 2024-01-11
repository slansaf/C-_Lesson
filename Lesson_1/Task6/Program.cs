using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{

		static void Main()
		{
			int[] mas = new int[6] { 3, -5, 2, -8, 3, -2 };
			for( int i = 0; i < mas.Length; i++){
					mas[i] *= -1;
					System.Console.Write($"{mas[i]} ," );
			}
		}
	}
}
