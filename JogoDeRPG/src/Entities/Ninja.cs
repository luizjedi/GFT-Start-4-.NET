namespace JogoDeRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja()
        {

        }

        public Ninja(string name, int level, string heroClass)
        {
            this.Name = name;
            this.Level = level;
            this.HeroClass = heroClass;
        }

        public override string Attack()
        {
            return $"{this.Name} Atacou com a sua Katana";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.Name} Lançou um ataque crítico com sua Katana com bônus de {bonus}";
            }
            else
                return $"{this.Name} Lançou um ataque com força fraca com bônus de {bonus}";
        }
    }
}

