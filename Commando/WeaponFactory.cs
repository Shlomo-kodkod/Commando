using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class WeaponFactory
    {
        private List<Weapon> weapons = new List<Weapon>();

        public Weapon CreatWeapon(string name, string manufacturer, int bulletsNumber)
        {
            Weapon weapon = new Weapon(name, manufacturer, bulletsNumber);
            return weapon;
        }

        public void AddWeaponToList(Weapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public List<Weapon> GetAllWeapons()
        {
            return this.weapons;
        }

    }
}
