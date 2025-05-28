using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class EnemyFactory
    {
        private List<Enemy> enemies = new List<Enemy>();


        public Enemy CreatEnemy(string name)
        {
            Enemy enmey = new Enemy(name);
            return enmey;
        }

        public List<Enemy> GetAllEnemy()
        {
            return this.enemies;
        }
    }
}
