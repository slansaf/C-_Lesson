using System;
using System.Collections.Generic;

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

			List<Robot> robots = new List<Robot> ();
			robots.Add(new Killer("Alex", 400, new byte[]{0, 0, 10}, 100));
			robots.Add(new Killer("Bob", 500, new byte[]{0, 10, 10}, 100));
			robots.Add(new Killer("John", 800, new byte[]{10, 0, 10}, 100));
			robots.Add(new Killer("Josh", 600, new byte[]{10, 20, 10}, 100));

			Robot newRobot = null; // Использование операторов as и  is

			foreach (Killer obj in robots)
			{
				if (obj.Name == "John"){
					newRobot = obj as Robot;
				}
				Console.WriteLine(obj is Robot);
			}

		}

	}


}