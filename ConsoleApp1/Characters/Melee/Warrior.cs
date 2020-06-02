namespace GameTest.Characters.Melee
{
    using GameTest.Armors.Mail;
    using GameTest.Characters.Enumarations;
    using GameTest.Weapons.Sharp;
    using System;
    using System.Security.Cryptography;

    public class Warrior : Melee
    {
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

        public Warrior()
            :this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        {

        }
        public Warrior(string name, int level)
          : this(name, level, Consts.Warrior.ABILITY_POINTS)
        {

        }
        public Warrior(string name, int level, int abilityPoints)
         : base(name, level, abilityPoints)
        {
            base.Name = name;
            base.Level = level;
            base.AbilityPoints = abilityPoints;
            base.Faction = Consts.Warrior.FACTION;
            base.HealthPoints = Consts.Warrior.HEALTH_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }
     
        public int Strike()
        {
            Random rng = new Random();
            return base.Weapon.Damage + rng.Next(5,15) + this.Level;
        }
        public int Execute()
        {
            throw new NotImplementedException();
        }
        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints +5 + this.Level;
        }
        public override int Attack()
        {
            return this.Strike();
        }
        public override int SpecialAttack()
        {
           return this.Execute();
        }
        public override int Defend()
        {
           return this.SkinHarden();
        }
    }
}

