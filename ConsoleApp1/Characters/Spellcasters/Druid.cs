
namespace GameTest.Characters.Spellcasters
{
    using GameTest.Armors.Leather;
    using GameTest.Characters.Enumarations;
    using GameTest.Weapons.Blunt;
    using System;

    public class Druid : Spellcaster
    {
        
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();


        public Druid()
            :this(Consts.Druid.NAME, Consts.Druid.LEVEL)
        {

        }

        public Druid(string name, int level)
            :this(name, level, Consts.Druid.MANA_POINTS)
        {

        }
        public Druid(string name, int level, int manaPoints)
        : base(name, level, manaPoints)
        {
            base.Name = name;
            base.Level = level;
            base.ManaPoints = manaPoints;
            base.HealthPoints = Consts.Druid.HEALTH_POINTS;
            base.Faction = Consts.Druid.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Moonfire()
        {
            Random rng = new Random();
            return base.Weapon.Damage + rng.Next(5, 15) + this.Level;
        }
        public int Starburst()
        {
            throw new NotImplementedException();
        }
        public int OneWithTheNature()
        {
            return base.BodyArmor.ArmorPoints + 6 + this.Level;
        }
        public override int Attack()
        {
            return this.Moonfire();
        }
        public override int SpecialAttack()
        {
            return this.Starburst();
        }
        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}
