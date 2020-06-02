namespace GameTest.Weapons
{
    public abstract class Weapon
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    System.Console.WriteLine("Weapon damage should be bigger than 1");
                }
            }
        }

    }
}
