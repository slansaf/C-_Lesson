using System;
using System.Collections.Generic;

namespace projact
{
	class Program
	{
		static void Main()
		{
			System.Console.Write("Введите длину массива: ");
			int len = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[len];
			FillArray(arr);
			PrintArray(arr);
			int num = PrimeNumbers(arr);
			System.Console.WriteLine($"Количество простых чисел: {num} ");
			
		}
		static void FillArray(int[] array)
		{
			Random rnd = new Random();
			for (int i = 0; i < array.Length; i++)	{
				array[i] = rnd.Next(2, 10);
			}
		}

		static void PrintArray(int[] array){
			foreach(int el in array){
				System.Console.Write($"{el} ");
			}
		}

		static int PrimeNumbers(int[] array){
			int k = 0;
			bool flag = false;
			for(int i = 0; i < array.Length; i++){
				for(int j = 2; j < array[i]; j++){
					if( array[i] % j == 0){
						flag = true;
					}
					if (flag == false){
						k++;
					}
					flag = true;
				}
			}
			return k;
		}

	}


}