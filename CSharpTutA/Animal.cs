using System;

namespace CSharpTutA
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name = "No Name")
        {
            Name = name;
        }

        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);
            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }
    }
}
