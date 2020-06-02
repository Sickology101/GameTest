namespace GameTest.Armors
{
    public abstract class Armor
    {

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    System.Console.WriteLine("Armor should be bigger than 1");
                }
            }
        }
    }
}
