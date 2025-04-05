using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Week2
{
    internal class Ammo
    {
        protected string name;
        protected int damage;

        public Ammo(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }


        public virtual int GetDamage()
        {
            return damage;
        }

        public virtual string GetData()
        {
            return $"Munición: {name} - Daño: {GetDamage()}";
        }
    }
}
