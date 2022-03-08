using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeRPG.src.Entities
{
   public class Knight : Hero
    {
        public Knight()
        {

        }
        public Knight(string name, int level, string heroClass)
        {
            this.Name = name;
            this.Level = level;
            this.HeroClass = heroClass;
        }

        public string Attack(int bonus)
        {
            return $"{this.Name} Atacou a espada com bônus de ataque de {bonus}";
        }
    }
}
