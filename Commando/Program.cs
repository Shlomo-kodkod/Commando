using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Program
    {
        public static void Main()
        {
            Commando commando = new Commando("Dany", "soldir101");
            commando.Walk();
            commando.Attack();
            commando.Hide();
            Console.WriteLine(commando);

            Weapon weapon = new Weapon("AK-47", "wwo", 30);

            weapon.Shoot();
            Console.WriteLine(weapon);

        }
    }
}
