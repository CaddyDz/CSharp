using System;

namespace CSharpTutA
{
		class Box
		{
				public double Length {get; set;}
				public double Width {get; set;}
				public double Breadth {get; set;}

				public Box()
					: this(1, 1, 1) {}
				
				public Box(double l, double w, double b)
				{
						Length = l;
						Width = w;
						Breadth = b;
				}

				public static Box operator +(Box box1, Box box2)
				{
					Box newBox = new Box()
					{
						Length = box1.Length + box2.Length,
						Width = box1.Width + box2.Width,
						Breadth = box1.Breadth + box2.Breadth
					};
					return newBox;
				}


				public static Box operator -(Box box1, Box box2)
				{
					Box newBox = new Box()
					{
						Length = box1.Length - box2.Length,
						Width = box1.Width - box2.Width,
						Breadth = box1.Breadth - box2.Breadth
					};
					return newBox;
				}

				public static bool operator ==(Box box1, Box box2)
				{
					if((box1.Length == box2.Length) && (box1.Width == box2.Width) && (box1.Breadth == box2.Breadth)) {
						return true;
					}
					return false;
				}

				public static bool operator !=(Box box1, Box box2)
				{
					if((box1.Length != box2.Length) || (box1.Width != box2.Width) || (box1.Breadth != box2.Breadth)) {
						return true;
					}
					return false;
				}

				public override string ToString()
				{
					return String.Format("Box with Height : {0} Width {1} Breadth : {2}", Length, Width, Breadth);
				}

				public static explicit operator int(Box b)
				{
					return (int)(b.Length + b.Width + b.Breadth) / 3;
				}

				public static implicit operator Box(int i)
				{
					return new Box(i, i , i);
				}
		}
}