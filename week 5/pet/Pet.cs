using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet
{
    internal class Pet
    {
        public string Name = "fiso";
        public int HungerLevel = 5;
        public int EnergyLevel = 5;
        public int HappinesLevel = 5;

        public void Feed()
        {
            HungerLevel -= 2;
            HappinesLevel++;
            Console.WriteLine(HungerLevel.ToString());
            Console.WriteLine(HappinesLevel.ToString());
           
        }

        public void Play()
        {
            HappinesLevel += 2;
            EnergyLevel -= 2;
            Console.WriteLine(EnergyLevel.ToString());
            Console.WriteLine(HappinesLevel.ToString());
            
        }


        public void Sleep()
        {
            EnergyLevel += 5;
            Console.WriteLine(EnergyLevel.ToString());
            
        }

        public void ShowStatus()
        {
            HungerLevel = Math.Clamp(HungerLevel, 0, 10);
            EnergyLevel = Math.Clamp(EnergyLevel, 0, 10);
            HappinesLevel = Math.Clamp(HappinesLevel, 0, 10);

            if (HungerLevel >= 10)
            {
                Console.WriteLine("The pet is in a very bad mood.");

            }
            if (EnergyLevel <= 0)
            {
                Console.WriteLine("cant play");
            }
        }
        public void ChekStatus()
        {
            Console.WriteLine(HungerLevel + EnergyLevel + HappinesLevel);
        }
    }
}



