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
            //Commando commando = new Commando("Dany", "commando101");
            //AirCommando airCommando = new AirCommando("Isreal", "commando202");
            //SeaCommando seaCommando = new SeaCommando("Haim", "commando303");

            //Commando[] commandos = new Commando[] { commando, airCommando, seaCommando };

            //foreach(Commando c in commandos)
            //{
            //    c.Attack();
            //}

            CommandoFactory c = new CommandoFactory();
            Commando s = c.CreatCommando("Commando", "mmm", "nnn");
            s.Attack();



        }
    }
}
