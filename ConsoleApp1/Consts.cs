using GameTest.Characters.Enumarations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest
{
    public static class Consts
    {
        public static class Warrior
        {
            public const string NAME = "Bob the Warrior";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const Factions FACTION = Factions.Fighter;
        }

        public static class Mage
        {
            public const string NAME = "Bob the Mage";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 60;
            public const Factions FACTION = Factions.Wizzard;
        }

        public static class Knight
        {
            public const string NAME = "Bob the Knight";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 110;
            public const Factions FACTION = Factions.Fighter;
        }

        public static class Assassin
        {
            public const string NAME = "Bob the Assassin";
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 90;
            public const Factions FACTION = Factions.Fighter;
        }

        public static class Necromancer
        {
            public const string NAME = "Bob the Necromancer";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 70;
            public const Factions FACTION = Factions.Wizzard;
        }

        public static class Druid
        {
            public const string NAME = "Bob the Druid";
            public const int LEVEL = 1;
            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 80;
            public const Factions FACTION = Factions.Wizzard;
        }
    }
}
