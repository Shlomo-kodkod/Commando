using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Enemy
    {
        string Name;
        int Life = 100;
        
        public Enemy(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }

        public bool IsAlive()
        {
            return this.Life > 0;
        }

        static void Scream()
        {
            Console.WriteLine("I'm an enemy");
        }
    }
}
