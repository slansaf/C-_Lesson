using System;
namespace projact
{
	class Program{
		static void Main(){
			// try{
			// 	int num = Convert.ToInt32(Console.ReadLine());
			// 	System.Console.WriteLine(num);
			// } catch(FormatException){
			// 	System.Console.WriteLine("Вы ввели не те данные!");
			// }

			try
			{
				int a, b, res;
			System.Console.WriteLine("Введите перове число: ");
			a = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("Введите второе число: ");
			b = Convert.ToInt32(Console.ReadLine());

			res = a / b;
			System.Console.WriteLine("Рузультат целочисленного деления: " + res);
			} 
			catch(DivideByZeroException){
				System.Console.WriteLine("Деление на ноль!");
			} 
			catch (System.Exception)
			{
				System.Console.WriteLine("Ввели не тот формат!");
			} 
			finally{
				System.Console.WriteLine("Нужно закрыть файл, вы не использовали метод Using");
			}
		}
	}
}