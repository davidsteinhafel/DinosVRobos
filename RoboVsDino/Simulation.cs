using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Simulation
    {
        Battlefield battlefield;
        List<Robot> robots;
        List<Dinosaur> dinosaurs;
        int round;

        //public void startGame()
        //{
        //    int userInput;
        //    userInput = Console.ReadLine();
        //    int yes;
        //    int no;
        //    yes = 1;
        //    no = 2;
        //    string result;
        //    result = "";
        //    result += userInput;
            
            
        //    Console.WriteLine("Welcome to Dinosaurs vs. Robots!!!");
        //    Console.WriteLine("Start Game?");
        //    Console.WriteLine("Press " + yes + "for YES " + "or " + no + "for NO");
        //    Console.ReadLine();

        //    if (userInput == yes)
        //    {
        //        //start and go to character selection
        //        pickCharacter();
        //    }
        //    else
        //    {
        //        //stop or close game or go back to start
        //    }
        }
        
        
        public void makeDinoList()
        {
            Dinosaur dinosaurs1 = new Dinosaur("Tyrannasaurus Rex", 8000, 500, 900);
            Dinosaur dinosaur2 = new Dinosaur("Triceratops", 12000, 500, 700);
            Dinosaur dinosaur3 = new Dinosaur("Velociraptor", 5500, 1000, 800);

            List<Dinosaur> dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(dinosaurs1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);

            Herd herd = new Herd(dinosaurs);
        }
        public void pickCharacter()
        {
            
            Console.WriteLine("Please pick your character");
            foreach(Dinosaur dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            Console.WriteLine(dinosaurs);
        }


        public void makeRobotList()
        {
            Robot robot1 = new Robot("Vaporizor4200", 7000, 6800, new Weapon(4200, "Rifle"));
            Robot robot2 = new Robot("Dunkmaster6900", 6500, 1000, new Weapon(6900, "Shotgun"));
            Robot robot3 = new Robot("Clapper1337", 8200, 8000, new Weapon(1337, "Sub-Machine Gun"));

            List<Robot> robots = new List<Robot>();
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);

            Fleet fleet = new Fleet(robots);
        }

        public void makeBattlefieldList()
        {
            Battlefield battlefield1 = new Battlefield("Icey Gourge", "Nome, Alaska");
            Battlefield battlefield2 = new Battlefield("Volcano Summit", "Honolulu, Hawaii");

            List<Battlefield> battlefields = new List<Battlefield>();
            battlefields.Add(battlefield1);
            battlefields.Add(battlefield2);
        }
    }

}
