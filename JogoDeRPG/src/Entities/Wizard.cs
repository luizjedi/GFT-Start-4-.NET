namespace JogoDeRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard()
        {

        }
        public Wizard(string name, int level, string heroClass)
        {
            this.Name = name;
            this.Level = level;
            this.HeroClass = heroClass;
        }
        public override string Attack()
        {
            return $"{this.Name} Lançou a sua magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.Name} Lançou magia super efetiva com bônus de {bonus}";
            }
            else
                return $"{this.Name} Lançou magia com força fraca com bônus de {bonus}";
        }
    }
}
