using System;
using System.Collections.Generic;
using System.Text;

namespace GameTest
{
    public static class Tools
    {
        public static void ColorfulWriteLine (string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfulCW (string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;
            switch (type)
            {
                case "GameTest.Characters.Melee.Warrior":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "GameTest.Characters.Melee.Knight":
                    color = ConsoleColor.Yellow;
                    break;
                case "GameTest.Characters.Melee.Assassin":
                    color = ConsoleColor.Gray;
                    break;
                case "GameTest.Characters.Spellcasters.Mage":
                    color = ConsoleColor.Cyan;
                    break;
                case "GameTest.Characters.Spellcasters.Necromancer":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "GameTest.Characters.Spellcasters.Druid":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
