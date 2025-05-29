using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Stone : IBreakable
    {
        public int strikeNum = 0;
        public int maxStrike;

        public bool IsWeaponWhole()
        {
            return this.strikeNum <= 5;
        }
        public int GetMaxStrike()
        {
            return this.maxStrike;
        }
        public int GetCurrentStrike()
        {
            return this.strikeNum;
        }

    }
}
