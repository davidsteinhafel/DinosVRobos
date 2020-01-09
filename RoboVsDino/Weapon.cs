using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Weapon
    {
        double attackPower;
        string weaponType;

        public Weapon(double attackPower, string weaponType)
        {

            this.attackPower = attackPower;
            this.weaponType = weaponType;
        }

    }
}
