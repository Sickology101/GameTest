namespace GameTest.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0)
                {
                    abilityPoints = value;
                }
                else
                {
                    System.Console.WriteLine("The ability points should be greater than 0");
                }
            }
        }
        public Melee(string name, int level, int abilityPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}

