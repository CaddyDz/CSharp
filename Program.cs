using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace CSharpTutA
{
	class Program
	{

		static void Main(string[] args)
		{
			Animal bowser = new Animal("Bowser", 45, 25);

			Stream stream = File.Open("AnimalData.dat", FileMode.Create);

			BinaryFormatter bf = new BinaryFormatter();

			bf.Serialize(stream, bowser);
			stream.Close();

			bowser = null;

			stream = File.Open("AnimalData.dat", FileMode.Open);

			bf = new BinaryFormatter();

			bowser = (Animal)bf.Deserialize(stream);
			stream.Close();

			System.Console.WriteLine(bowser.ToString());

			bowser.Weight = 50;

			XmlSerializer serializer = new XmlSerializer(typeof(Animal));

			using (TextWriter tw = new StreamWriter(@"/Users/caddydz/C#Data/bowser.xml"))
			{
				serializer.Serialize(tw, bowser);
			}

			bowser = null;

			XmlSerializer deserializer = new XmlSerializer(typeof(Animal));

			TextReader reader = new StreamReader(@"/Users/caddydz/C#Data/bowser.xml");

			object obj = deserializer.Deserialize(reader);
			bowser = (Animal)obj;
			reader.Close();

			System.Console.WriteLine(bowser.ToString());

			List<Animal> theAnimals = new List<Animal>
			{
				new Animal("Mario", 60, 30),
				new Animal("Luigi", 55, 24),
				new Animal("Peach", 40, 20)
			};

			using (Stream fs = new FileStream(@"/Users/caddydz/C#Data/animals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
			{
				XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
				serializer2.Serialize(fs, theAnimals);
			}

			theAnimals = null;

			XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

			// Can't find file
			using (FileStream fs2 = File.OpenRead(@"/Users/caddydz/C#Data/animals.xml"))
			{
				theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
			}

			foreach (Animal a in theAnimals)
			{
				System.Console.WriteLine(a.ToString());
			}

			Console.ReadLine();
		}
	}
}
