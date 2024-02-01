using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{

		static void Main()
		{
			char [] chars = {'a', '1', 'b', 'a', '!', '5'};
			string str = GetStringFromArray(chars);
			System.Console.WriteLine(str);

			string str2 = "HellooooO World!";
			char[] chars2 = StringToCharArray(str2);
			System.Console.WriteLine($"[{string.Join(", ", chars2)}]");
			System.Console.WriteLine(FindeVowelLetter(str2));

		}

		static string GetStringFromArray(char [] array){
			string str = ""; //StringBuilder
			foreach(char el in array){
				str += el;
			}
			return str;
		}

		static char [] StringToCharArray(string str){
			char[] chars = new char [str.Length];
			for (int i = 0; i < str.Length; i++){
				chars[i] = str[i];
			}
			return chars;
		}

		static int FindeVowelLetter(string str){
			string vowels = "aoyuie";
			int counter = 0;
			foreach(char el in str.ToLower()){
				if (vowels.Contains(el)){
					counter++;
				}
			}
			return counter;
		}
	}
}
