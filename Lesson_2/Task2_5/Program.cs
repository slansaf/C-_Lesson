using System;
namespace project
{
	class Program
	{
		static void Main(){
			
			int res1 = Summa(15, 6);
			int a = 34, b = 12;
			int res2 = Summa(a, b);
			
			Print(res1.ToString());
			Print(res2.ToString());

			byte[] nums1 = {2, 5, 8, 3, 8, 9};
			byte result = SummaMas(nums1);
			Print(result.ToString());

		}

		public static void Print(string word){
			System.Console.WriteLine(word);
		}

		public static int Summa(int x, int y){
			return x + y;

		}

		public static byte SummaMas(byte[] digits){
			byte summ = 0;
			foreach(byte el in digits){
				summ += el;
			}

			return(summ);
		}
	}
}