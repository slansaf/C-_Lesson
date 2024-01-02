using System;
namespace prject
{
	class Program
	{
		static void Main()
		{
			//Работа со строками

			string word = "Hello";

			/* System.Console.WriteLine(word.Length);
			word = String.Concat(word, "!!!");
			System.Console.WriteLine(word);
			System.Console.WriteLine(String.Compare(word, "Hello!!!"));
   			*/

			string people = "Sasha, Petay, Kostay";
			string[] name = people.Split(new char[]{','});
			PrintMas(name);
			people = string.Join(" ", name);
			System.Console.WriteLine(people);
		}

		static void Print(string word){
			System.Console.WriteLine("Elem: " + word.Trim());
		}

		static void PrintMas(string[] word){
			foreach (string el in word)
				Print(el);
		}
	}
}
