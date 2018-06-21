using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace CSharpTutA
{
		class Program
		{

				static void Main(string[] args)
				{
					Thread t = new Thread(Print1)	;

					t.Start();

				for (int i = 0; i < 1000; i++)
				{
					Console.Write(0);
				}

					Console.ReadLine();
				}

				static void Print1()
				{
					for (int i = 0; i < 1000; i++)
					{
							System.Console.Write(1);
					}
				}
		}
}
