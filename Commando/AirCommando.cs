using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class AirCommando : Commando
    {
        public AirCommando(string Name, string CodeName) : base(Name, CodeName) { }

        public override void Attack()
        {
            Console.WriteLine($"Air commando warrior attacking now");
            
        }
        public void Drop()
        {
            Console.WriteLine("The commando's dropping now");
        }

    }
}
