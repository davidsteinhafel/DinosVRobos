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
        public double attackPower;
        
        

        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }
      public void Attack(Robot robot)
        {
            Console.WriteLine(type + " " + attackPower + " AP");
            Console.ReadLine();
            robot.health -= attackPower;
            Console.WriteLine(robot.name + " HP Remaining = " + robot.health + " HP");
            Console.ReadLine();
        }
    }
}
