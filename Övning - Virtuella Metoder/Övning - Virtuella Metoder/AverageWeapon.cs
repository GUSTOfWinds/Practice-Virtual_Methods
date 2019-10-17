using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning___Virtuella_Metoder
{
    class AverageWeapon: Weapon
    {
        public override int Attack()
        {
            int avgDamage = (minDamage + maxDamage) / 2;
            return avgDamage;
        }
    }
}