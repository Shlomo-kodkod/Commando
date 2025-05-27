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

        public bool IsThereBullets()
        {
            return this.bulletsNumber > 0;
        }

        public void Shoot()
        {
            if (this.IsThereBullets())
            {
                Console.WriteLine("Shooting");
                this.bulletsNumber--;
            }
            else
            {
                Console.WriteLine("The weapon is empty");
            }
            
        }

        public override string ToString()
        {
            return $"Name: {this.name}\n" +
                $"Manufacturer: {this.manufacturer}\n" +
                $"BulletsNumber: {this.bulletsNumber}";
        }
    }
}
