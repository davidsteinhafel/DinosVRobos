using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Battlefield
    {
        List<Battlefield> battlefields;
        string name;
        string location;

        public Battlefield(List<Battlefield> battlefields)
        {
            this.battlefields = battlefields;
        }
        public Battlefield(string name, string location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
