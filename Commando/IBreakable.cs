using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public interface IBreakable
    {
        public bool IsWeaponWhole();
        public int GetMaxStrike();
        public int GetCurrentStrike();
    }
}
