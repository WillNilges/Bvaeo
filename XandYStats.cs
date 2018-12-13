using System;
namespace CodeFile1
{
    class CodeFile1
    {
        static void Main()
        {
            Random rnd = new Random();
            int xatk = rnd.Next(41, 100);
            int xdef = rnd.Next(30, 100);
            int xagl = rnd.Next(28, 82);
            int xend = rnd.Next(50, 60);

            int yatk = rnd.Next(51, 85);
            int ydef = rnd.Next(68, 90);
            int yagl = rnd.Next(10, 100);
            int yend = rnd.Next(30, 57);

            string ret = @"
            ";

            string betta = "*";
            string outtaHundo = "/100";
            string attack = "attack - ";
            string defense = "defense - ";
            string agility = "agility - ";
            string endurance = "endurance - ";

            Console.Clear();
            Console.WriteLine("An asterisk (*) next to a stat means that combatant has a higher stat.");

            Console.WriteLine("-----X stats-----");
            string assembledAttackForX = attack + xatk + outtaHundo;
            string superiorAssembledAttackForX = attack + xatk + outtaHundo + betta;
            if (xatk > yatk) {
              Console.WriteLine(superiorAssembledAttackForX);
            }
            else
            {
              Console.WriteLine(assembledAttackForX);
            }
            string assembledDefenseForX = defense + xdef + outtaHundo;
            string superiorAssembledDefenseForX = defense + xdef + outtaHundo + betta;
            if (xdef > ydef) {
              Console.WriteLine(superiorAssembledDefenseForX);
            }
            else
            {
              Console.WriteLine(assembledDefenseForX);
            }

            string assembledAgilityForX = agility + xagl + outtaHundo;
            string superiorAssembledAgilityForX = agility + xagl + outtaHundo + betta;
            if (xagl > yagl) {
              Console.WriteLine(superiorAssembledAgilityForX);
            }
            else
            {
              Console.WriteLine(assembledAgilityForX);
            }
            string assembledEnduranceForX = endurance + xend + outtaHundo;
            string superiorAssembledEnduranceForX = endurance + xend + outtaHundo + betta;
            if (xend > yend) {
              Console.WriteLine(superiorAssembledEnduranceForX);
            }
            else
            {
              Console.WriteLine(assembledEnduranceForX);
            }

            Console.WriteLine(ret);

            Console.WriteLine("-----Y stats-----");
            string assembledAttackForY = attack + yatk + outtaHundo;
            string superiorAssembledAttackForY = attack + yatk + outtaHundo + betta;
            if (xatk < yatk) {
              Console.WriteLine(superiorAssembledAttackForY);
            }
            else
            {
              Console.WriteLine(assembledAttackForY);
            }

            string assembledDefenseForY = defense + ydef + outtaHundo;
            string superiorAssembledDefenseForY = defense + ydef + outtaHundo + betta;
            if (xdef < ydef) {
              Console.WriteLine(superiorAssembledDefenseForY);
            }
            else
            {
              Console.WriteLine(assembledDefenseForY);
            }
            string assembledAgilityForY = agility + yagl + outtaHundo;
            string superiorAssembledAgilityForY = agility + yagl + outtaHundo + betta;
            if (xagl < yagl) {
              Console.WriteLine(superiorAssembledAgilityForY);
            }
            else
            {
            Console.WriteLine(assembledAgilityForY);
            }
            string assembledEnduranceForY = endurance + yend + outtaHundo;
            string superiorAssembledEnduranceForY = endurance + yend + outtaHundo + betta;
            if (xend < yend) {
              Console.WriteLine(superiorAssembledEnduranceForY);
            }
            else
            {
              Console.WriteLine(assembledEnduranceForY);
            }

            Console.WriteLine(ret);
            Console.WriteLine("Battle (1)");
            Console.WriteLine("Re-Roll (2)");
            if (Console.ReadKey("1")) {
              Process.Start();
            }

        }
    }
}
