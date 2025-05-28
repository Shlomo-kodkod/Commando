using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class WeaponFactory
    {
        private List<Firearm> weapons = new List<Firearm>();

        public Firearm CreatWeapon(string name, string manufacturer, int bulletsNumber)
        {
            Firearm weapon = new Firearm(name, manufacturer, bulletsNumber);
            return weapon;
        }

        public void AddWeaponToList(Firearm weapon)
        {
            this.weapons.Add(weapon);
        }

        public List<Firearm> GetAllWeapons()
        {
            return this.weapons;
        }

    }
}
