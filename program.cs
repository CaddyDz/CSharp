using System;

namespace Caddy {
	class Program {
		public static void main() {
			Console.Write("What is your name?");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, {0}! glad to know you!!", name);
		}
	}
}
