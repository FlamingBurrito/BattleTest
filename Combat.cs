using System;
//using Math.Random;
using System.Collections.Generic;

namespace battleTest
{
    public static class Combat
    {
        public static Random rng;
        //Character defender;
        //Character attacker;

        static battle battleForm;
        
        static Combat()
        {
            rng = new Random();
        }

        static public void setForm(battle parentForm){
            battleForm = parentForm;
        }
        /*
        static public void output(string outputString)
        {
            battleForm.richTextBox1.SelectionColor = System.Drawing.Color.Black;
            battleForm.richTextBox1.AppendText(outputString+"\n");
        }*/

        static public void output(string outputString, bool endLine = true, bool bold = false,
            bool underline = false, System.Drawing.Color textColor = default(System.Drawing.Color))
        {
            if (!bold && !underline)
            {
                //not bolded or underlined - REGULAR
                battleForm.richTextBox1.SelectionFont = new 
                    System.Drawing.Font(battleForm.richTextBox1.SelectionFont, System.Drawing.FontStyle.Regular);
            }
            if (bold && !underline)
            {
                //bold text, but don't underline
                battleForm.richTextBox1.SelectionFont = new 
                    System.Drawing.Font(battleForm.richTextBox1.SelectionFont,System.Drawing.FontStyle.Bold); 
            }
            if (!bold && underline)
            {
                //underlined and not bold
                battleForm.richTextBox1.SelectionFont = new 
                    System.Drawing.Font(battleForm.richTextBox1.SelectionFont, System.Drawing.FontStyle.Underline);
            }
            if (bold && underline)
            {
                //BOLD AND UNDERLINE
                battleForm.richTextBox1.SelectionFont = new 
                    System.Drawing.Font(battleForm.richTextBox1.SelectionFont, System.Drawing.FontStyle.Underline |System.Drawing.FontStyle.Bold);
            }
            battleForm.richTextBox1.SelectionColor = textColor;
            if (endLine) { battleForm.richTextBox1.AppendText(outputString + "\n"); }
            else { battleForm.richTextBox1.AppendText(outputString); }
            
        }
        /*
        static public void output(string outputString, System.Drawing.Color textColor)
        {
            battleForm.richTextBox1.SelectionColor = textColor;
            battleForm.richTextBox1.AppendText(outputString+"\n");
            battleForm.richTextBox1.SelectionColor = System.Drawing.Color.Black;
        }*/

        static public float getDamage(float successes)
        {
            float dmg = successes * 2f;
            //Console.WriteLine("damage: " + dmg.ToString());
            dmg = weaknesses(dmg);
            //Console.WriteLine("total damage done: " + dmg.ToString());
            return dmg;
        }

        static public float weaknesses(float dmg)
        {
            //look for character weaknesses/resistances
            //change dmg as necessary, spit it back out
            float resistance = -50f;
            dmg = dmg + (dmg * (resistance / 100f));
            return dmg;
        }

        static public List<int> rollDice(int dice, int sides)
        {
            List<int> rolls = new List<int>();
            for (int r = 0; r < dice; r++)
            {   //roll the number of dice passed to funciton
                int roll = rng.Next(1, (sides + 1));
                //get a random number between 1 and number of sides passed
                rolls.Add(roll);
                //Console.Write(roll.ToString() + " ");
                //add the roll into the list of rolls
                //Roll of 10 or better adds an additional roll
                if (roll > 9)
                {
                    dice++;
                    //Console.Write("(!) ");
                }
            }
            return rolls;
        }

        static public List<int> rollDice(int dice, int sides, int bonus)
        {
            List<int> rolls = new List<int>();
            for (int r = 0; r < dice; r++)
            {   //roll the number of dice passed to funciton
                int roll = rng.Next(1, (sides + 1)) + bonus;
                //get a random number between 1 and number of sides passed, add bonus
                rolls.Add(roll);
                //Console.Write(roll.ToString() + " ");
                //add the roll into the list of rolls
                //Roll of 10 or better adds an additional roll
                if (roll > 9)
                {
                    dice++;
                    //Console.Write("(!) ");
                }
            }
            return rolls;
        }

        static public bool rollCheck(int target, int outOf)
        {
            bool success = false;
            if (target >= rng.Next(1, outOf)) { success = true; }
            return success;
        }

        static public int countSuccesses(List<int> rolls, int targetNumber)
        {
            int successes = 0;
            for (int r = 0; r < rolls.Count; r++)
            {
                if (rolls[r] >= targetNumber) { successes++; }
            }
            //Console.WriteLine("\n" + successes.ToString() + " successes counted in rolls.");
            return successes;
        }

       static public float getDamage(int min,  int max, int Attack, int Defense)
       {
           float totalDamage = 0f;
           //roll dice, modify shit, etc
           return totalDamage;
       }
    }
}//end namespace