using System;

namespace projact
{
	class Killer : Robot
	{

		public int Health { get; set; }

		public Killer() { }

		public Killer(string name, int weigth, byte[] coordinates, int health) : base(name, weigth, coordinates)
		{
			this.Health = health;
			base.printValues();
		}

		public void Lazer()
		{
			this.surname = "Убийца";
			System.Console.WriteLine("Lazer shuter. He's surname: " + this.surname);

		}

	}
}