using System;


namespace projact
{
	class Robot
	{

		private static int count = 0;

		private string name = "";
		private int weigth = 0;
		private byte[] coordinates = new byte[] { 0, 0, 0 };

		protected string surname = "";

		//Это Аксессор - если нужно что либо контролировать (ввод от пользователя данных)
		public int Weight
		{
			get
			{
				System.Console.Write("Результат: ");
				return this.weigth;
			}
			set
			{
				if (value < 1)
					this.weigth = 1;
				else if (value > 5000)
					this.weigth = 5000;
				else
					this.weigth = value;
			}
		}

		public string Name{
			get{
				return name;
			}
			private set {}
		}

		public Robot(string name, int weigth, byte[] coordinates)
		{
			System.Console.WriteLine("Object has been created");
			this.setValues(name, weigth, coordinates);
			count++;
		}

		public Robot(string name)
		{
			this.setValues(name, weigth, coordinates);
			count++;
		}

		public Robot() { }

		public void setValues(string name, int weigth, byte[] coordinates)
		{
			this.name = name;
			this.weigth = weigth;
			this.coordinates = coordinates;
			count++;
		}

		public void printValues()
		{
			System.Console.WriteLine(this.name + " weight " + this.weigth + ". Coordinates: ");
			foreach (byte el in coordinates)
			{
				System.Console.WriteLine(el);
			}
		}

		public static void Print()
		{
			System.Console.WriteLine("Это статический метод, count = " + count);
		}

	}
}