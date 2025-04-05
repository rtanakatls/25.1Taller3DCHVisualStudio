using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Week2
{
    internal class RangedWeapon : Weapon
    {
        protected Ammo ammo;

        public RangedWeapon(string name, int damage, Ammo ammo) : base(name, damage)
        {
            this.ammo = ammo;
        }

        public override int GetDamage()
        {
            return damage + ammo.GetDamage();
        }

        public override string GetData()
        {
            return $"Arma: {name} - Daño del arma: {damage} - {ammo.GetData()} - Daño total: {GetDamage()}";
        }

    }
}
