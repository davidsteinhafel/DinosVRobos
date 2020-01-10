﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Fleet
    {
        public List<Robot> robots = new List<Robot>();

        public Fleet()
        {
            Robot robot1 = new Robot("Vaporizor4200", 7000, 6800, new Weapon(4200, "Rifle"));
            Robot robot2 = new Robot("Dunkmaster6900", 6500, 1000, new Weapon(6900, "Shotgun"));
            Robot robot3 = new Robot("Clapper1337", 4300, 8000, new Weapon(1337, "Sub-Machine Gun"));
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }


    }
}
