using System;
using System.Collections.Generic;

namespace _03.ImmuneSystem
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            double currentHealth = initialHealth;
            List<string> viruses = new List<string>();
            string currentVirus = Console.ReadLine();
            bool isDead = false; 

            while (currentVirus != "end")
            {
                int virusStrength = 0;
                int timeToDefeat = 0;
                int minutes = 0;
                int seconds = 0;

                for (int i = 0; i < currentVirus.Length; i++)
                {
                    virusStrength += currentVirus[i]; 
                }
                virusStrength /= 3;
                timeToDefeat = virusStrength * currentVirus.Length;

                if (!viruses.Contains(currentVirus))
                {
                    viruses.Add(currentVirus);
                }
                else
                {
                    timeToDefeat /= 3;
                }
                minutes = timeToDefeat / 60;
                seconds = timeToDefeat % 60;
                Console.WriteLine($"Virus {currentVirus}: {virusStrength} => {timeToDefeat} seconds");
                if (timeToDefeat < currentHealth)
                {
                    currentHealth -= timeToDefeat;
                    Console.WriteLine($"{currentVirus} defeated in {minutes}m {seconds}s." +
                        $"\r\nRemaining health: {currentHealth}");
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    isDead = true;
                    break;
                }

                currentHealth = Math.Floor(currentHealth * 1.2);
                if (currentHealth > initialHealth)
                {
                    currentHealth = initialHealth;
                }
                currentVirus = Console.ReadLine();
            }

            if (!isDead)
            {                                                                                                                                                                                                                                                                                               
                Console.WriteLine($"Final Health: {currentHealth}");
            }
        }
    }
}
