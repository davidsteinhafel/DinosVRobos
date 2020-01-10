using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Robot
    {
        public string name;
        public double health;
        public double powerLevel;
        public Weapon weapon;
        
        public Robot(string name, double health, double powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
        }
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
        }

    }
}
