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
			setValues(_name, _weigth, _coordinates);
			count++;
		}

		public Robot() {
			count++;
		}

		public void setValues(string _name, int _weigth, byte[] _coordinates){
			name = _name;
			weigth = _weigth;
			coordinates = _coordinates;
			count++;
		}

		public void printValues(){
			System.Console.WriteLine(name + " weight " + weigth + ". Coordinates: ");
			foreach( byte el in coordinates){
				System.Console.WriteLine(el);
			}
		}

		public static void Print(){
			System.Console.WriteLine("Это статический метод, count = " + count);
		}

	}
}