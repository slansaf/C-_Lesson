using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{

		static void Main()
		{
			int num = 23423;
			int result = SummaDigitFromNumber(num);
			System.Console.WriteLine(result);
		}

		static int  SummaDigitFromNumber(int num)
		{
			System.Console.WriteLine($"Call:{num}");
			if (num < 10){
				System.Console.WriteLine($"Hi, i am here");
				return num;
			}
			int sum = num % 10;
			int temp = SummaDigitFromNumber(num / 10);
			System.Console.WriteLine($"Co back:{num}, {temp}");
			sum+=temp;
			return sum;
		}

	
	}
}
