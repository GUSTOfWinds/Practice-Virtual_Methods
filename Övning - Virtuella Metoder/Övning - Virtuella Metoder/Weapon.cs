using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning___Virtuella_Metoder
{
    class Weapon
    {
        protected int minDamage = 1;
        protected int maxDamage = 10;

        protected Random randomgenerator = new Random();

        public virtual int Attack()
        {
            return randomgenerator.Next(minDamage, maxDamage);
        }
    }
}
