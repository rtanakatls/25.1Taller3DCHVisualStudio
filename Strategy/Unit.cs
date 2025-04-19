using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Strategy
{
    internal class Unit
    {
        protected string name;
        protected int life;

        public Unit(string name, int life) 
        {
            this.name = name;
            this.life = life;
        }

        private void ChangeLife(int value)
        {
            life -= value;
            if(life < 0)
            {
                life = 0;
            }
        }

        public void TakeDamage(int damage)
        {
            ChangeLife(-damage);
        }
    }
}
