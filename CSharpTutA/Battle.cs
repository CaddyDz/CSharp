using System;

namespace CSharpTutA
{
    class Battle
    {
        // StartFight
        // Warrior1 Warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        // GetAttackResult
        // Warrior1, WarriorB
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();
            double dmg2WarB = warAAttkAmt - warBBlkAmt;
            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name,
                warriorB.Name,
                dmg2WarB);

            Console.WriteLine("{0} Has {1} Health \n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorius\n",
                    warriorB.Name,
                    warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";
        }
        // Calculate 1 warriors attack and the others block

        // Substract block from attack

        // If there was damage substract that from the health

        // Print out info on who attacked who and fow how much damage

        // Provide output on the change in health

        // Chack if the warriors health fell below 0 and if so print a message and then send a response that will end the loop
    }
}
