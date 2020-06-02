namespace GameTest.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;
        public int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                if (value >= 0)
                {
                    manaPoints = value;
                }
                else
                {
                    System.Console.WriteLine("The ability points should be greater than 0");
                }
            }
        }
        public Spellcaster(string name, int level, int manaPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}
