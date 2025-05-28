using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public interface IShootable
    {
        public bool IsThereBullets();
        public void Shoot();
    }
}
