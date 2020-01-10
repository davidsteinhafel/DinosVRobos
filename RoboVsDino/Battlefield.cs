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
        public int dinoWins;
        public int roboWins;

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
                
                Console.WriteLine("\n Dinosaur " + dinosaur.type);
            }
            foreach (Robot robot in fleet.robots)
            {
                Console.WriteLine("\n Robot " + robot.name);
            }
        }





        public void StartBattle()
        {
            for(int i = 0; i >= 0 && i < 3; i++)
            {
                Console.WriteLine("\n");
                while (fleet.robots[i].health > 0 && herd.dinosaurs[i].health > 0)
                {
                    herd.dinosaurs[i].Attack(fleet.robots[i]);
                    fleet.robots[i].Attack(herd.dinosaurs[i]);
                }
                if(herd.dinosaurs[i].health > 0 && fleet.robots[i].health <= 0)
                {
                    dinoWins++;
                    string winner;
                    winner = herd.dinosaurs[i].type;
                    Console.WriteLine("WINNER IS!!! " + winner);
                }
                else if(fleet.robots[i].health > 0 && herd.dinosaurs[i].health <= 0)
                {
                    roboWins++;
                    string winner;
                    winner = fleet.robots[i].name;
                    Console.WriteLine("WINNER IS!!! " + winner);
                }

            }
            // ////////////////////////////////
            //Console.WriteLine("\n");
            //while (fleet.robots[0].health > 0 && herd.dinosaurs[0].health > 0)
            //{
            //    herd.dinosaurs[0].Attack(fleet.robots[0]);
            //    fleet.robots[0].Attack(herd.dinosaurs[0]);
            //}
            //if (herd.dinosaurs[0].health > 0 && fleet.robots[0].health <= 0)
            //{
            //    dinoWins++;
            //    string winner;
            //    winner = herd.dinosaurs[0].type;
            //    Console.WriteLine("WINNER IS!!! " + winner);
            //}
            //else if(fleet.robots[0].health > 0 && herd.dinosaurs[0].health <= 0)
            //{
            //    roboWins++;
            //    string winner;
            //    winner = fleet.robots[0].name;
            //    Console.WriteLine("WINNER IS!!! " + winner);
            //}

            //Console.WriteLine("\n");
            //while (fleet.robots[1].health > 0 && herd.dinosaurs[1].health > 0)
            //{
            //    herd.dinosaurs[1].Attack(fleet.robots[1]);
            //    fleet.robots[1].Attack(herd.dinosaurs[1]);
            //}
            //if (herd.dinosaurs[1].health > 0 && fleet.robots[1].health <= 0)
            //{
            //    dinoWins++;
            //    string winner;
            //    winner = herd.dinosaurs[1].type;
            //    Console.WriteLine("WINNER IS!!! " + winner);
            //}
            //else if (fleet.robots[1].health > 0 && herd.dinosaurs[1].health <= 0)
            //{
            //    roboWins++;
            //    string winner;
            //    winner = fleet.robots[1].name;
            //    Console.WriteLine("WINNER IS!!! " + winner);
            //}
            //Console.WriteLine("\n");
            //while (fleet.robots[2].health > 0 && herd.dinosaurs[2].health > 0)
            //{
            //    herd.dinosaurs[2].Attack(fleet.robots[2]);
            //    fleet.robots[2].Attack(herd.dinosaurs[2]);
            //}
            //if (herd.dinosaurs[2].health > 0 && fleet.robots[2].health <= 0)
            //{
            //    dinoWins++;
            //    string winner;
            //    winner = herd.dinosaurs[2].type;
            //    Console.WriteLine("WINNER IS!!! " + winner);
            //}
            //else if (fleet.robots[2].health > 0 && herd.dinosaurs[2].health <= 0)
            //{
            //    roboWins++;
            //    string winner;
            //    winner = fleet.robots[2].name;
            //    Console.WriteLine("WINNER IS!!! " + winner);
                
            //}

        }
        public void EndBattle()
        {
            if (roboWins > dinoWins)
            {
                Console.WriteLine("Robots Win!!!");
                Console.ReadLine();
            }
            else if (dinoWins > roboWins)
            {
                Console.WriteLine("Dinosaurs Win!!!");
                Console.ReadLine();
            }

        }
    }
}
