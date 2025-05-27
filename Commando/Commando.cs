using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Commando
    {
        private string name;
        public string codeName { get; set; }
        public string[] tools = new string[] { "hammer", "scalpel", "rope", "bag", "canteen" };
        public string status = "stand";


        public Commando(string Name, string CodeName)
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

        public virtual void Attack()
        {
            Console.WriteLine($"Commando warrior attacking now");
        }
        public string ValidateRank()
        {
            Console.WriteLine("Enter your Rank: ");
            string rank = Console.ReadLine();

            if ((! rank.Equals("general")) || (!rank.Equals("colonel")))
            {
                return "You do not have permission for this information";
            }
            else
            {
                return (rank.Equals("colonel") ? this.name : this.codeName);
            }
        }

        public void SayName(string CommanderRank)
        {
            string name = ValidateRank();
            Console.WriteLine(name);
        }

        public string GetTools()
        {
            string tools = "";
            foreach(string tool in this.tools)
            {
                tools += tool + ", ";
            }
            return tools;
        }

        public override string ToString()
        {

            return $"Tools: {this.GetTools()}\n" +
                $"Status: {this.status}";
        }
    }
}
