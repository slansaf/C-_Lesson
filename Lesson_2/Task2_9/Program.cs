using System;
namespace projact
{
	class Program{
		static void Main(){
			
			Robot bot = new Robot("Bot", 800, new byte[] {0, 0, 0});
			bot.printValues();


			Robot killer = new Robot();
			killer.setValues("Killer", 1000, new byte[] {0, 10, 10});
			killer.printValues();
		}

	}


}