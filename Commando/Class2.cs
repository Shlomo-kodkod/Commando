using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
     public class Weapon
    {
        public string name;
        public string manufacturer;
        public int bulletsNumber;

        public Weapon(string Name, string Manufacturer, int BulletsNumber)
        {
            this.name = Name;
            this.manufacturer = Manufacturer;
            this.bulletsNumber = BulletsNumber;
        }

        public void Shoot()
        {
            Console.WriteLine("Shooting");
            this.bulletsNumber--;
        }
    }
}
