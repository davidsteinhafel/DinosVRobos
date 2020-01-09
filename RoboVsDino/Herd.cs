using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Herd
    {
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        public Herd()
        {
            Dinosaur dinosaurs1 = new Dinosaur("Tyrannasaurus Rex", 8000, 500, 900);
            Dinosaur dinosaur2 = new Dinosaur("Triceratops", 12000, 500, 700);
            Dinosaur dinosaur3 = new Dinosaur("Velociraptor", 5500, 1000, 800);
            dinosaurs.Add(dinosaurs1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }

    }
}
