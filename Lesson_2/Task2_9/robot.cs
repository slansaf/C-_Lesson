using System;

namespace projact
{
	class Robot{

		private static int count = 0;

		private string name = "";
		private int weigth = 0;
		private byte[] coordinates = new byte[] {0, 0, 0};

		public Robot(string _name, int _weigth, byte[] _coordinates) {
			System.Console.WriteLine("Object has been created");
			this.setValues(name, weigth, coordinates);
			count++;
		}

		public Robot() {
			count++;
		}

		public void setValues(string name, int weigth, byte[] coordinates){
			this.name = name;
			this.weigth = weigth;
			this.coordinates = coordinates;
			count++;
		}

		public void printValues(){
			System.Console.WriteLine(this.name + " weight " + this.weigth + ". Coordinates: ");
			foreach( byte el in coordinates){
				System.Console.WriteLine(el);
			}
		}

		public static void Print(){
			System.Console.WriteLine("Это статический метод, count = " + count);
		}

	}
}