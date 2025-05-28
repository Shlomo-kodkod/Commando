using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class CommandoFactory
    {
        private List<Commando> commandos = new List<Commando>();

        public Commando CreatCommando(string type,string name, string codeName)
        {
            Commando commando;
            switch (type)
            {
                case "SeaCommando":
                    commando = new SeaCommando(name, codeName);
                    return commando;

                case "AirCommando":
                    commando = new AirCommando(name, codeName);
                    return commando;

                default:
                    commando = new Commando(name, codeName);
                    return commando;
            }
            
        }

        public void AddCommandoToList(Commando commando)
        {
            this.commandos.Add(commando);
        }

        public List<Commando> GetAllCommandos()
        {
            return this.commandos;
        }
    }
}
