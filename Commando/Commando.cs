using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class Commando
    {
        public string name;
        public string codeName;
        public string[] tools = new string[] { "hammer", "scalpel", "rope", "bag", "canteen" };
        public string status = "stand";


        public Commando(string Name, string CodeName, string[] Tools, string Status)
        {
            this.name = Name;
            this.codeName = CodeName;
        }

        public void Walk()
        {
            this.status = "walk";
            Console.WriteLine($"the warrior is {this.status}");
        }

        public void Hide()
        {
            this.status = "hide";
            Console.WriteLine($"the warrior is {this.status}");
        }

        public void Attack()
        {
            Console.WriteLine($"Commando with code name {this.codeName} attacking now");
        }
    }
}
