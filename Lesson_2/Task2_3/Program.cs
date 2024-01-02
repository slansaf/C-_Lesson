using System;
	namespace progect
	{
		class Program{
			static void Main(){
				//Одномерные массивы

				/*Console.WriteLine("Hallo World!!!");
				byte[] nums = new byte[5];
				nums[0] = 250;
				nums[1] = 50;
				nums[2] = 20;
				nums[3] = 100;
				nums[4] = 25;
				System.Console.WriteLine("El: " + nums[0]+1);
				*/

				/*string[] words = new string[] {"Jhon", "Bob", "Alex"};

				words[1] = "Josh";
				
				for(byte i = 0; i < words.Length; i++){
					System.Console.WriteLine("El: " + words[i]);
				}*/

				short[] numbers = new short[10];
				short summa = 0;

				Random random = new Random();
				for(byte i = 0; i < numbers.Length; i++){
					
					numbers[i] = Convert.ToInt16(random.Next(5, 15));
					System.Console.WriteLine("El: " + numbers[i]);

					summa += numbers[i];
				}

				System.Console.WriteLine("Summa = " + summa);

			}
		}
	}
