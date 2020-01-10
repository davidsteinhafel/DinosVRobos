using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Battlefield
    {
        public List<Battlefield> battlefields;
        public string name;
        public string location;
        public Herd herd;
        public Fleet fleet;

        public Battlefield(string name, string location)
        {
            this.name = name;
            this.location = location;
            herd = new Herd();
            fleet = new Fleet();
        }

        public void PrintOutContestants()
        {
            foreach (Dinosaur dinosaur in herd.dinosaurs)
            {
                
                Console.WriteLine("Dinosaur" + dinosaur.type);
            }
            foreach (Robot robot in fleet.robots)
            {
                Console.WriteLine("Robot" + robot.name);
            }
        }





        public void StartBattle()
        {
            while (fleet.robots[0].health > 0 && herd.dinosaurs[0].health > 0)
            {
                herd.dinosaurs[0].Attack(fleet.robots[0]);
                fleet.robots[0].Attack(herd.dinosaurs[0]);
            }
            while (fleet.robots[1].health > 0 && herd.dinosaurs[1].health > 0)
            {
                herd.dinosaurs[1].Attack(fleet.robots[1]);
                fleet.robots[1].Attack(herd.dinosaurs[1]);
            }
            while (fleet.robots[2].health > 0 && herd.dinosaurs[2].health > 0)
            {
                herd.dinosaurs[2].Attack(fleet.robots[2]);
                fleet.robots[2].Attack(herd.dinosaurs[2]);
            } 
        }
    }
}
