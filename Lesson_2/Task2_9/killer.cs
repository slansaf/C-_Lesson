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
		}

		public override void printValues() // Добавили виртуальный метод вывода информатиции и переписали метод печати (добавыили ещё одну позицию)
		{
			base.printValues();
			System.Console.WriteLine("Health: " +  this.Health);
		}

		public void Lazer()
		{
			this.surname = "Убийца";
			System.Console.WriteLine("Lazer shuter. He's surname: " + this.surname);

		}

	}
}