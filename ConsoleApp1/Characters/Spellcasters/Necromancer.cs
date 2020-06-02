

namespace GameTest.Characters.Spellcasters
{
    using GameTest.Armors.Leather;
    using GameTest.Characters.Enumarations;
    using GameTest.Weapons.Blunt;
    using System;

    public class Necromancer : Spellcaster
    {
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();


        public Necromancer()
            : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL)
        {

        }
        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.MANA_POINTS )
        {

        }
        public Necromancer(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.Name = name;
            base.Level = level;
            base.ManaPoints = manaPoints;
            base.HealthPoints = Consts.Necromancer.HEALTH_POINTS;
            base.Faction = Consts.Necromancer.FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int ShadowRage()
        {
            Random rng = new Random();
            return base.Weapon.Damage + rng.Next(5, 15) + this.Level;
        }
        public int VampireTouch()
        {
            throw new NotImplementedException();
        }
        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints + 6 + this.Level;
        }
        public override int Attack()
        {
            return this.ShadowRage();
        }
        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }
        public override int Defend()
        {
            return this.BoneShield();
        }
    }
}
