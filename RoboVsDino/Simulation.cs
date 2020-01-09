using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Simulation
    {
        public Battlefield battlefield;

        public Simulation()
        {
            battlefield = new Battlefield("Icey Gourge", "Nome, Alaska");
        }
        public void startGame()
        {
            string intro;
            intro = "WELCOME!!!......Billions of years ago dinosaurs were wiped from the planet. Most scientist believe it was due to a large meteor - we know better! IT WAS THE ROBOTS!!!!";
            Console.WriteLine(intro);
            Console.ReadLine();
            GoToBattle();
        }

        public void GoToBattle()
        {
            Console.WriteLine("You are now entering " + battlefield.name + " located in " + battlefield.location);
            battlefield.PrintOutContestants();
        }


        //public void makeBattlefieldList()
        //{
        //    Battlefield battlefield1 = new Battlefield("Icey Gourge", "Nome, Alaska");
        //    Battlefield battlefield2 = new Battlefield("Volcano Summit", "Honolulu, Hawaii");

        //    List<Battlefield> battlefields = new List<Battlefield>();
        //    battlefields.Add(battlefield1);
        //    battlefields.Add(battlefield2);
        //}
    }

}
