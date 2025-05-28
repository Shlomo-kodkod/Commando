using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class M16 : Firearm, IShootable
    {
        public M16() : base("M16", "colt", 29)
        {

        }
    }
}
