using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
     public class AK47 : Firearm , IShootable
    {
        public AK47() : base("AK47", "KALASHNIKOV", 30) { }

    }
}
