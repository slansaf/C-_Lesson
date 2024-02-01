using System;
using System.Net.WebSockets;

namespace project
{

	class Program
	{
		
		static void Main()
		{
			Console.Clear();
			int [] array = {1, 3, 5, 7, 9};
			System.Console.WriteLine(BinarySearch(array, -1));
		}

		static int BinarySearch(int [] array, int item){
			int low = 0;
			int high = array.Length;

			while (low <= high){
				int mid = (low + high) / 2;
				int guess = array[mid];
				if (guess == item) 
					return mid;
				else if (guess > item)
					high = mid - 1;
				else
					low = mid + 1;
			}
			return -1;
		}
	
	}
}
