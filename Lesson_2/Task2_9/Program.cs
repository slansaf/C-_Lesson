using System;
namespace projact
{
	class Program
	{
		static void Main()
		{

			Robot bot = new Robot("Bot", 800, new byte[] { 0, 0, 0 });
			bot.printValues();


			Killer killer = new Killer("Killer", 1000, new byte[] { 0, 10, 10 }, 100);
			killer.Lazer();


			Robot bot1 = new Robot("Bot");
			bot1.Weight = 200;                     // Использовали Аксессор
			System.Console.WriteLine(bot1.Weight);

			Robot.Print(); //Применение статической функции

		}

	}


}