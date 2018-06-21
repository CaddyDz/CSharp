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
					Thread t = new Thread(() => CountTo(10));
					t.Start();

					new Thread(() => {
						CountTo(5);
						CountTo(6);
					}).Start();

					Console.ReadLine();
				}

				static void CountTo(int maxNum)
				{
					for (int i = 0; i <= maxNum; i++)
					{
							System.Console.WriteLine(i);
					}
				}
		}
}
