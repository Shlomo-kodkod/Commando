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

        public void AddEnemyToList(Enemy enemy)
        {
            this.enemies.Add(enemy);
        }

        public List<Enemy> GetAllEnemies()
        {
            return this.enemies;
        }
    }
}
