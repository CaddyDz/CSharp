using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpTutA
{
	class Program
	{

		static void Main(string[] args)
		{
			DirectoryInfo currDir = new DirectoryInfo(".");

			DirectoryInfo salimsDir = new DirectoryInfo(@"/Users/caddydz");

			System.Console.WriteLine(salimsDir.FullName);
			System.Console.WriteLine(salimsDir.Name);
			System.Console.WriteLine(salimsDir.Parent);
			System.Console.WriteLine(salimsDir.Attributes);
			System.Console.WriteLine(salimsDir.CreationTime);

			DirectoryInfo dataDir = new DirectoryInfo(@"/Users/caddydz/C#Data");

			// Directory.Delete(@"/Users/caddydz/C#Data");

			string[] customers = {
						"Bob Smith",
						"Sally Smith",
						"Robert Smith"
					};

			string textFilePath = @"/Users/caddydz/C#Data/testfile1.txt";

			File.WriteAllLines(textFilePath, customers);

			foreach (string cust in File.ReadAllLines(textFilePath))
			{
				System.Console.WriteLine($"Customer : {cust}");
			}

			DirectoryInfo myDataDir = new DirectoryInfo(@"/Users/caddydz/C#Data");

			FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

			System.Console.WriteLine("Matches : {0}", txtFiles.Length);

			foreach (FileInfo file in txtFiles)
			{
				System.Console.WriteLine(file.Name);
				System.Console.WriteLine(file.Length);
			}

			string testFilePath2 = @"/Users/caddydz/C#Data/testfile2.txt";

			FileStream fs = File.Open(textFilePath2, FileMode.Create);

			string randString = "This is a random string";

			byte[] rsByteArray = Encoding.Default.GetBytes(randString);

			fs.Write(rsByteArray, 0, rsByteArray.Length);

			fs.Position = 0;

			byte[] fileByteArray = new byte[rsByteArray.Length];

			for (int i = 0; i < rsByteArray.Length; i++)
			{
				fileByteArray[i] = (byte)fs.ReadByte();
			}

			System.Console.WriteLine(Encoding.Default.GetString(fileByteArray));

			fs.Close();

			string textFilePath3 = @"/Users/caddydz/C#Data/testfile3.txt";

			StreamWriter sw = File.CreateText(textFilePath3);

			sw.Write("This is a random ");
			sw.WriteLine("sentence");
			sw.WriteLine("This is another sentence");

			sw.Close();

			StreamReader sr = File.OpenText(textFilePath3);

			System.Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));

			System.Console.WriteLine("1st String : {0}", sr.ReadLine());

			System.Console.WriteLine("Everything : {0}", sr.ReadToEnd());

			sr.Close();

			string textFilePath4 = @"/Users/caddydz/C#Data/testfile4.dat";

			FileInfo datFile = new FileInfo(textFilePath4);

			BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

			string randText = "Random Text";

			int myAge = 42;

			double height = 6.25;

			bw.Write(randText);
			bw.Write(myAge);
			bw.Write(height);

			bw.Close();

			BinaryReader br = new BinaryReader(datFile.OpenRead());

			System.Console.WriteLine(br.ReadString());
			System.Console.WriteLine(br.ReadInt32());
			System.Console.WriteLine(br.ReadDouble());

			br.Close();
			Console.ReadLine();
		}
	}
}
