using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class ColdWeapon
    {
        public string Name;
        public int Weight;
        public string Color;
        public bool IsWhole = true;

        public ColdWeapon(string name, int weight, string color)
        {
            this.Name = name;
            this.Weight = weight;
            this.Color = color;
        }


        public void Strike()
        {
            if (this.IsWhole)
            {
                Console.WriteLine("Attacking with cold weapon");
            }
        }

    }
}
