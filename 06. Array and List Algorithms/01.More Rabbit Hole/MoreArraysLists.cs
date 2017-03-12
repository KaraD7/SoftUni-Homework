namespace _01.More_Rabbit_Hole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MoreArraysLists
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split().ToList();
            int energy = int.Parse(Console.ReadLine());

            int currentIndex = 0;
            bool lastBomb = false;

            while (energy > 0 )
            {
                string [] commandParams = command[currentIndex].Split('|');
                string currentCommand = commandParams[0];
                lastBomb = false;

                if (currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                int value = int.Parse(commandParams[1]);
                switch (currentCommand)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % command.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % command.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        command.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;
                        break;
                }

                if (command[command.Count - 1] != "RabbitHole")
                {
                    command.RemoveAt(command.Count - 1);
                }
                command.Add("Bomb|" + energy);
            }
            if (energy <= 0 && lastBomb)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (energy<=0 && !lastBomb)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
