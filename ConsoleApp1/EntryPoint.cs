using GameTest;
using GameTest.Characters;
using GameTest.Characters.Melee;
using GameTest.Characters.Spellcasters;
using System;
using System.Collections.Generic;
using System.Threading;

public class EntryPoint
{

    static void Main()
    {
        Random rng = new Random();
        int start = rng.Next(0, 2);
        Melee currentMelee;
        Spellcaster currentSpellcaster;
        bool gameOver = false;
        List<Character> characters = new List<Character>()
        {
            new Warrior(),
            new Knight(),
            new Assassin(),
            new Mage(),
            new Necromancer(),
            new Druid()
        };

        List<Melee> meleeTeam = new List<Melee>();
        List<Spellcaster> spellTeam = new List<Spellcaster>();

        foreach (var charater in characters)
        {
            if (charater is Melee)
            {
                meleeTeam.Add((Melee)charater);
            }
            else if (charater is Spellcaster)
            {
                spellTeam.Add((Spellcaster)charater);
            }
        }
        while (!gameOver)
        {
            currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
            currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
            if (start == 1)
            {
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                Thread.Sleep(500);
            }
            else
            {
                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());
                Thread.Sleep(500);
            }

            if (!currentSpellcaster.IsAlive)
            {
                currentMelee.WonBattle();
                spellTeam.Remove(currentSpellcaster);
                if (spellTeam.Count == 0)
                {
                    Tools.ColorfulWriteLine("\nFighter team wins", ConsoleColor.Red);
                    break;
                }
                else
                {
                    currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
                }
            }
            if (start == 1)
            {
               currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());
                Thread.Sleep(500);
            }
            else
            { 
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                Thread.Sleep(500);

            }

            if (!currentMelee.IsAlive)
            {
                currentSpellcaster.WonBattle();
                meleeTeam.Remove(currentMelee);
                if (meleeTeam.Count == 0)
                {
                    Tools.ColorfulWriteLine("\nWizzard team wins", ConsoleColor.Red);
                    break;
                }
                else
                {
                    currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                }
            }
        }
    }
}
