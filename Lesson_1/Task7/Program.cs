﻿using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
	// Разница между максимальным и минимальным элементами массива

	// Нахождение минимума массива
	public static double FindMin(double[] numbers)
	{
		//Напишите свое решение здесь
		double min = numbers[0];
		foreach (float el in numbers)
		{
			if (el < min)
			{
				min = el;
			}
		}
		return (min);
	}

	// Нахождение максимума массива
	public static double FindMax(double[] numbers)
	{
		//Напишите свое решение здесь
		double max = numbers[0];
		foreach (float el in numbers)
		{
			if (el > max)
			{
				max = el;
			}
		}
		return (max);
	}



	public static void PrintResult(double[] array)
	{
		//Напишите свое решение здесь
		double findeNum = FindMax(array) - FindMin(array);
		Console.WriteLine(Math.Round(findeNum, 2));
	}
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
	public static void Main(string[] args)
	{
		double[] array;


		if (args.Length >= 1)
		{
			// Объединяем все аргументы командной строки в одну строку
			string joinedArgs = string.Join(" ", args);

			// Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
			array = joinedArgs.Split(", ")
										 .Select(double.Parse)
										 .ToArray();

			// Теперь arr содержит преобразованные в целые числа из командной строки

		}
		else
		{
			// Если аргументов на входе нет
			array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 }; // Создание массива
		}
		UserInputToCompileForTest.PrintResult(array);
	}
}