using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Week2
{
    internal class MenuWeek2 : Menu
    {
        private List<Weapon> weapons;

        public MenuWeek2()
        {
            weapons = new List<Weapon>();
        }

        public override void Execute()
        {
            weapons.Add(new Weapon("Espada", 10));
            weapons.Add(new Weapon("Lanza", 20));
            weapons.Add(new RangedWeapon("Arco", 5,new Ammo("Flecha",5)));
            weapons.Add(new Weapon("Maza", 50));
            weapons.Add(new RangedWeapon("Pistola", 5, new Ammo("Bala", 5)));

            ShowWeapons();


        }

        private void ShowWeapons()
        {
            foreach(Weapon weapon in weapons)
            {
                Console.WriteLine(weapon.GetData());
            }
        }
    }
}
