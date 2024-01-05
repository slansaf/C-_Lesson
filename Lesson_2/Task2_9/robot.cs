using System;

namespace projact
{
	class Robot{

		private string name = "";
		private int weigth = 0;
		private byte[] coordinates = new byte[] {0, 0, 0};

		public Robot(string _name, int _weigth, byte[] _coordinates) {
			System.Console.WriteLine("Object has been created");
			setValues(_name, _weigth, _coordinates);
		}

		public Robot() {}
		
		public void setValues(string _name, int _weigth, byte[] _coordinates){
			name = _name;
			weigth = _weigth;
			coordinates = _coordinates;
		}

		public void printValues(){
			System.Console.WriteLine(name + " weight " + weigth + ". Coordinates: ");
			foreach( byte el in coordinates){
				System.Console.WriteLine(el);
			}
		}

	}
}