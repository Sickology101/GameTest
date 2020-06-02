namespace GameTest.Characters
{
    using GameTest.Armors;
    using GameTest.Characters.Enumarations;
    using GameTest.Characters.Interfaces;
    using GameTest.Weapons;

    public abstract class Character : IAttack, IDefend
    {
        private Factions faction;
        private string name;
        private Weapon weapon;
        private Armor bodyArmor;
        private bool isAlive;
        private int level;
        private int healthPoints;
        private int scores;
        public Factions Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;

            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 100)
                {
                    name = value;
                }
                else
                {
                    System.Console.WriteLine("The name is too short or too long. Must be between 2 and 10 characters");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    healthPoints = value;
                }
                else
                {
                    System.Console.WriteLine("The HP has to be greater than 0");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    System.Console.WriteLine("Level should be between 1 and 100");
                }
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public bool IsAlive {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public int Scores {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }
        public Character ()
        {

        }
        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();
                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                System.Console.WriteLine($"{this.name} received {damage} damage from {attackerName}, but his armor was too high!");
                return;
            }
            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} health points!", type);
            }
        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public abstract int Defend();

        public abstract int Attack();

        public abstract int SpecialAttack();
        public void WonBattle()
        {
             this.level++;
             System.Console.WriteLine($"{this.name} has leveled UP!");
        }
    }

}
