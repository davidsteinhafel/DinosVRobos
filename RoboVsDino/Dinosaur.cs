using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Dinosaur
    {
        public string type;
        public double health;
        public double energy;
        public double attackType;
        
        

        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackType = attackPower;
        }
      public void Attack(Robot robot)
        {
            if(health > 0)
            {
                Console.WriteLine(type + " " + attackType + " AP");
                Console.ReadLine();
                robot.health -= attackType;
                Console.WriteLine(robot.name + " HP Remaining = " + robot.health + " HP");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(type + " has tragically died!");
                Console.ReadLine();
            }

        }
    }
}
