using System;
using System.Collections.Generic;

namespace projact
{
	class Program
	{
		static void Main()
		{	
			System.Console.Write("Введите значение количества элементов массива: ");
			int lim = Convert.ToInt32(Console.ReadLine());
			int[] array = new int [lim];
			NewArray(array);
			PrintArray(array);
		
			
		}

		static void PrintArray(int[] arr){
			foreach(int el in arr)
				System.Console.Write($"{el} ");
		}

		static void NewArray(int[] arr)
		{
			Random rand = new Random();
			for(int i = 0; i < arr.Length; i++){
				arr[i] = rand.Next(-100, 100);
			}
		}

	}


}