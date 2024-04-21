using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Trådar
{
    public class Car
    {
        public string Name { get; }
        public int Distance { get; private set; }
        public int Speed { get; private set; }

        private readonly Random random;

        public Car(string name)
        {
            Name = name;
            Distance = 0;
            Speed = 120; 
            random = new Random();
        }

        public void StartRace()
        {
            Console.WriteLine($"{Name} has started the race!");

            while (Distance < 100) 
            {
                Move();
                Thread.Sleep(1000); 
            }

            Console.WriteLine($"{Name} has finished the race!");
        }

        private void Move()
        {
            Distance += Speed / 3600; 
            CheckForEvent();
        }

        private void CheckForEvent()
        {
            int chance = random.Next(50); 

            if (chance == 0) 
            {
                Console.WriteLine($"{Name} is out of gas! Stopping for refueling...");
                Thread.Sleep(30000); 
            }
            else if (chance <= 1) 
            {
                Console.WriteLine($"{Name} has a flat tire! Stopping to change the tire...");
                Thread.Sleep(20000); 
            }
            else if (chance <= 6) 
            {
                Console.WriteLine($"{Name} has a bird on the windshield! Stopping to clean the windshield...");
                Thread.Sleep(10000); 
            }
            else if (chance <= 15) 
            {
                Console.WriteLine($"{Name} has engine trouble! Speed reduced by 1 km/h.");
                Speed--; 
            }
        }
    }
}
