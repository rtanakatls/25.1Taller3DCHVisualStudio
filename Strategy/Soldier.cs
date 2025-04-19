using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Strategy
{
    internal class Soldier : Unit
    {
        protected int damage;

        public Soldier(string name, int life, int damage) : base(name,life)
        {
            this.damage = damage;
        }

        public int GetDamage()
        {
            return damage;
        }
    }
}
