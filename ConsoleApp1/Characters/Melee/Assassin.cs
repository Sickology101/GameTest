
namespace GameTest.Characters.Melee
{
    using GameTest.Armors.Leather;
    using GameTest.Characters.Enumarations;
    using GameTest.Weapons.Sharp;
    using System;

    public class Assassin : Melee
    {
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();

        public Assassin()
          :this(Consts.Assassin.NAME, Consts.Assassin.LEVEL)
      {

      }

        public Assassin(string name, int level)
          :this(name, level, Consts.Assassin.ABILITY_POINTS)
      {

      }
        public Assassin(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.Name = name;
            base.Level = level;
            base.AbilityPoints = abilityPoints;
            base.Faction = Consts.Assassin.FACTION;
            base.HealthPoints = Consts.Assassin.HEALTH_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int Raze()
        {
            Random rng = new Random();
            return base.Weapon.Damage + rng.Next(5, 15)+ this.Level;
        }
        public int Bleed()
        {
            throw new NotImplementedException();
        }
        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 5 + this.Level;

        }
        public override int Attack()
        {
            return this.Raze();
        }
        public override int SpecialAttack()
        {
            return this.Bleed();
        }
        public override int Defend()
        {
            return this.Survival();
        }
    }
}
