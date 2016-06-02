using System;

namespace First
{
	class Box
	{
		public double length;
		public double breadth;
		public double height;

		public void setLength (double len)
		{
			length = len;
		}

		public void setBreadth (double bre) {
			breadth = bre;
		}

		public void setHeight (double hei) {
			height = hei;
		}

		public double getVolume() {
			return length * breadth * height;
		}

	}

	class Line {
		private double length;

		public Line(){
			Console.WriteLine ("Obiectul este creat.");
		}

		~Line() {
			Console.WriteLine ("Obiectul este sters.");
		}

		public Line(double len) {
			Console.WriteLine ("Obiectul este creat, length = {0} ", len);
			length = len;
		}

		public void setLength(double len){
			length = len;
		}

		public double getLength() {
			return length;
		}
	}




	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		
			Box box1 = new Box ();
			Box box2 = new Box ();
			Box box3 = new Box ();

			double volume = 0.0;

			box1.height = 5.0;
			box1.length = 6.0;
			box1.breadth = 7.0;

			box2.height = 10.0;
			box2.length = 12.0;
			box2.breadth = 13.0;

			volume = box1.breadth * box1.height * box1.length;
			Console.WriteLine ("Volumul cutiei nr. 1: {0} ", volume);

			volume = box2.breadth * box2.height * box2.length;
			Console.WriteLine ("Volumul cutiei nr. 2: {0} ", volume);

			box3.setLength (9.0);
			box3.setBreadth (2.0);
			box3.setHeight (3.0);

			volume = box3.getVolume ();
			Console.WriteLine ("Volumul cutiei 3 este de : {0}", volume);

			Line line = new Line ();
			line.setLength (6.0);
			Console.WriteLine ("Lungimea liniei este de : {0}", line.getLength ());

			Line line1 = new Line (9.0);
			line1.setLength (34.0);
			Console.WriteLine ("Noua lungime este : {0} ", line1.getLength ());

			Shape s = new Shape ();
			s.setHeight (23);
		}
	}


}
