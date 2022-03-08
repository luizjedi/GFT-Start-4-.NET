namespace JogoDeRPG.src.Entities
{
    public abstract class Hero
    {
        #region "Properties"
        public int Level { get; set; }
        public string Name { get; set; }
        public string HeroClass { get; set; }
        #endregion

        public Hero()
        {

        }

        public Hero(string name, int level, string heroClass)
        {
            this.Name = name;
            this.Level = level;
            this.HeroClass = heroClass;
        }

        public virtual string Attack()
        {
            return $"{this.Name} Atacou com a sua espada";
        }

        public override string ToString()
        {
            return ($"{this.Name} \n\n Lv. {this.Level} - Class: {this.HeroClass}" +
                    $"\n _____________________________\n");
        }
    }
}
