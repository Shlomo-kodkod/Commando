using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
     public class SeaCommando : Commando
    {
        
        public SeaCommando(string Name, string CodeName) : base(Name, CodeName) { }

        public override void Attack()
        {
            Console.WriteLine($"Sea commando warrior attacking now");
        }
        public void Drop()
        {
            Console.WriteLine("The commando's swimm now");
        }

    }
}
