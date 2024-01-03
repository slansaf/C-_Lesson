using System;

namespace projact
{
	class Robot{

		private string name;
		private int weigth;
		private byte[] coordinates;

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