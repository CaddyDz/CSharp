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
					int num = 1;

					for (int i = 0; i < 10; i++)
					{
							System.Console.WriteLine(num);
							Thread.Sleep(1000);
							num++;
					}
					System.Console.WriteLine("Thread Ends");
					Console.ReadLine();
				}
		}
}
