using System;
using System.Collections.Generic;

namespace progect{
	class Program{
		static void Main(){
			//Цикл  foreach и динамические массивы
			/*
			short[,] nums = {
				{4, 3, 5}, 
				{32, 5, 6}, 
				{8, 3, 78},
			};
			foreach(short el in nums) {
				System.Console.WriteLine("El: " + el);
			}*/

			List<int> numbers = new List<int>(){
				4, 3, 5
			};

			numbers.Add(40);
			numbers.Add(100);
			numbers.Add(10);

			numbers.Remove(5);
			numbers.Sort();
			numbers.Reverse();

			foreach(int el in numbers){
				System.Console.WriteLine("El: " + el);
			}


		}
	}
}