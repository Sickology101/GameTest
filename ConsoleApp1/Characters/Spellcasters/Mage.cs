

namespace GameTest.Characters.Spellcasters
{
    using GameTest.Armors.Cloth;
    using GameTest.Characters.Enumarations;
    using GameTest.Weapons.Blunt;
    using System;

    public class Mage : Spellcaster
    {
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();

        public Mage()
            :this (Consts.Mage.NAME, Consts.Mage.LEVEL)
        {

        }

        public Mage(string name, int level)
            :this(name, level, Consts.Mage.MANA_POINTS)
        {

        }
        public Mage(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.Name = name;
            base.Level = level;
            base.ManaPoints = manaPoints;
            base.HealthPoints = Consts.Mage.HEALTH_POINTS;
            base.Faction = Consts.Mage.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }
        public int Fireball()
        {
            Random rng = new Random();
            return base.Weapon.Damage + rng.Next(5, 15) + this.Level;
        }
        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 6 + this.Level;
        }
        public override int Attack()
        {
            return this.Fireball();
        }
        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
        public override int Defend()
        {
           return this.Meditation();
        }
    }
}
