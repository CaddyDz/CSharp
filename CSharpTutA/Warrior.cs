using System;

namespace CSharpTutA
{
    class Warrior
    {
        // Name Health Attack Maximus Block Maximus

        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Random numbers
        Random rnd = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attkMax = 0, double blockMax = 0) {

            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        // Attack
        // Generate a random attack from 1 to the maximum attack
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        // Block
        // Generate a random block from 1 tp the maximum block

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
