
namespace GameTest.Characters.Melee
{
    using GameTest.Armors.Mail;
    using GameTest.Characters.Enumarations;
    using GameTest.Weapons.Blunt;
    using System;

    public class Knight : Melee
    {
       
        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();

        public Knight()
            :this(Consts.Knight.NAME, Consts.Knight.LEVEL)
        {

        }

        public Knight(string name, int level)
            :this(name, level, Consts.Knight.ABILITY_POINTS)
        {

        }
        public Knight(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.Name = name;
            base.Level = level;
            base.AbilityPoints = abilityPoints;
            base.Faction = Consts.Knight.FACTION;
            base.HealthPoints = Consts.Knight.HEALTH_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int HolyBlow()
        {
            Random rng = new Random();
            return base.Weapon.Damage + rng.Next(5, 15) + this.Level;
        }
        public int PuriyfySoul()
        {
            throw new NotImplementedException();
        }
        public int RighteousWings()
        {
            return base.BodyArmor.ArmorPoints + 5 + this.Level;
        }
        public override int Attack()
        {
            return this.HolyBlow();
        }
        public override int SpecialAttack()
        {
            return this.PuriyfySoul();
        }
        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}