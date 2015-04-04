﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ini;

namespace battleTest
{
    public class Skill
    {

        //public string skillName;
        public string Name;
        public string targetGroup;
        public string targetNumber;

        public string description;

        public bool freeAction;

        public int coolDown;
        public bool isWarm;

        public int accuracy;
        public int criticalRatio;
        public float criticalDamage;

        public string element;			//fire, ice, etc
        public string method;				//melee, physical, ranged, magic
        public string damageType;			//piercing, slashing, blunt

        public int attackNumber;
        public int minDamage;
        public int maxDamage;
        public string attackStat;
        public string defenseStat;

        public int staminaUse;

        public Character user;
        public List<Character> targets;

        public string functions;

        public Skill(string newSkill)
        {
           // Console.WriteLine("opening skill file for " + newSkill);
            IniFile newFile = new IniFile("../../" + newSkill + ".skil");
            loadSkill(newFile);
        }

        void loadSkill(IniFile currentFile)
        {
            string skillName = System.IO.Path.GetFileNameWithoutExtension(currentFile.path);
            //TBName.Text = currentFile.IniReadValue(skillName, "name");

            Name = currentFile.IniReadValue(skillName, "name");
            targetGroup = currentFile.IniReadValue(skillName, "targetGroup");
            targetNumber = currentFile.IniReadValue(skillName, "targets");
            description = currentFile.IniReadValue(skillName, "desc");

            staminaUse = Convert.ToInt32(currentFile.IniReadValue(skillName, "staminaUse"));
            freeAction = Convert.ToBoolean(currentFile.IniReadValue(skillName, "freeAction"));
            isWarm = Convert.ToBoolean(currentFile.IniReadValue(skillName, "isWarm"));
            accuracy = Convert.ToInt32(currentFile.IniReadValue(skillName, "hitChance"));
            criticalRatio = Convert.ToInt32(currentFile.IniReadValue(skillName, "criticalRatio"));
            criticalDamage = float.Parse(currentFile.IniReadValue(skillName, "criticalDamage"));
            attackNumber = Convert.ToInt32(currentFile.IniReadValue(skillName, "attackNumber"));
            element = currentFile.IniReadValue(skillName, "element");

            functions = currentFile.IniReadValue(skillName, "function");

            string[] commands = functions.Split(new string[] { ";" }, System.StringSplitOptions.None);
            for (int i = 0; i < commands.Length; i++)
            {
                string[] args = commands[i].Split(new string[] { "," }, System.StringSplitOptions.None);
                if (args[0].Equals("attack"))
                {
                    minDamage += int.Parse(args[1]);
                    maxDamage += int.Parse(args[2]);
                }
            }

        }
        internal void scriptRead(string input)
        {
            //input = "walk,5;attackUp,Anger,1";
            string[] commands = input.Split(new string[] { ";" }, System.StringSplitOptions.None);
            bool statusContinue = true;

            for (int i = 0; i < commands.Length; i++)
            {
                string[] args = commands[i].Split(new string[] { "," }, System.StringSplitOptions.None);

                if (args[0].Equals("attack"))
                {
                    attack(int.Parse(args[1]), int.Parse(args[2]), args[3]);
                }
                if (args[0].Equals("addStatus"))
                {
                    if (statusContinue)
                    {	//if this is false, the statuses before had an endflag so we stop looking for statuses to add
                        statusContinue = addStatus(args[1], int.Parse(args[2]), int.Parse(args[3]), args[4], Convert.ToBoolean(args[5]));
                    }
                }
                if (args[0].Equals("addTurn"))
                {
                    //somehow add another turn of the user into the TC?
                }
                if (args[0].Equals("alwaysCrit"))
                {
                    //change the skills accuracy so that it is a critical hit
                }
                if (args[0].Equals("alwaysHit"))
                {
                    //chance the skill so that it hits, but is not necessarily critical
                }
                if (args[0].Equals("createItem"))
                {
                }
                if (args[0].Equals("changeSet"))
                {
                }
                if (args[0].Equals("heal"))
                {
                }
                if (args[0].Equals("ignoreArmor"))
                {
                }
                if (args[0].Equals("removeBuffs"))
                {
                }
                if (args[0].Equals("removeDebuffs"))
                {
                }
                if (args[0].Equals("removeStatus"))
                {
                }
                if (args[0].Equals("useAmmo"))
                {
                    //remove the selected status,
                    //attack
                    //repeat until all of the status are depleted
                }

                /*
                 addStatus(status,#ofstacks,chance%,target,endFlag)
addTurn(#ofTurns,target)
alwaysCrit()
alwaysHit()
attack(#dmgPerDie,statToUse,target)
changeSet(skill1,skill2,skill3,skill4)
createItem(item,chance%,target,endFlag)
heal(#toheal%,Health/Stamina,target)
ignoreArmor(#pointsOfArmor)
removeBuffs(chance%,target)
removeDebuffs(chance%,target)
removeStatus(status,chance%,target)
useAmmo(status) */
                //if(args[0].Equals("run"))
                //{
                //	doRunCode(int.parse(args[1]),args[2],..);
                //}
                /*etc etc check args[0] for the function you want to call and every following index is a variable to pass*/
            }
        }

        private bool addStatus(string status, int stacks, int chance, string target, bool endFlag)
        {
            if (target == "enemies")
            {
                foreach (Character c in targets)
                {
                    if (c.team != user.team)
                    {
                        Random rng = new Random();
                        int activate = rng.Next(1, 101);
                        if (activate <= chance)
                        {
                            c.addStatus(status);
                        }
                    }
                }
                if (endFlag) { return false; }
                else return true;
            }
            if (target == "allies")
            {
                foreach (Character c in targets)
                {
                    if (c.team == user.team)
                    {
                        Random rng = new Random();
                        int activate = rng.Next(1, 101);
                        if (activate <= chance)
                        {
                            c.addStatus(status);
                        }
                    }
                }
                if (endFlag) { return false; }
                else return true;
            }
            if (target == "self")
            {
                Random rng = new Random();
                int activate = rng.Next(1, 101);
                if (activate <= chance)
                {
                    user.addStatus(status);
                }
                if (endFlag) { return false; }
                else return true;
            }
            return true;
        }

        private void attack(int min, int max, string targetGroup)
        {
            int AC = accuracyCheck();
            if (AC > 0) //accuracy check first
            {
                switch (targetGroup)
                {
                    case "enemies":
                        foreach (Character c in targets)
                        {
                            if (c.team != user.team)
                            {
                                float dmg = getDamage();
                                if (AC == 2) { dmg = criticalHit(dmg); } //critical hit
                                c.damage(dmg, element, false);
                            }
                        }
                        break;

                    case "allies":
                        foreach (Character c in targets)
                        {
                            if (c.team == user.team)
                            {
                                float dmg = getDamage();
                                if (AC == 2) { dmg = criticalHit(dmg); } //critical hit
                                c.damage(dmg, element, false);
                            }
                        }
                        break;

                    default:
                        Combat.output("What happened here? Attack no targets?");
                        break;
                }
            }
            else
            {
                Combat.output(Name + " missed!");
            }
        }

        public bool use(Character skillUser, List<Character> target)
        {
            user = skillUser;
            targets = target;
            user.MP -= staminaUse;

            if (functions.Length > 0)
            {
                scriptRead(functions);
            }

            //asAttack(user,target);

            return true;
        }

        int accuracyCheck()
        {
            int check = 0;
            float targetNum = ((user.tempAccuracy + accuracy)/targets[0].tempEvasion)*100f;
            if (Combat.rollCheck((int)targetNum, 101)) { check = 1; }
            if (Combat.rollCheck((int)criticalRatio, 101)) { check = 2; }
            //roll for accuracy, return 1 if hit, 2 if crit            
            return check;
        }

        float getDamage()
        {
           // float totalDamage = 0f;
            List<int> damageDice = Combat.rollDice(user.tempAttack, 10);

            int successes = Combat.countSuccesses(damageDice,targets[0].tempDefense);
            //int dmg = Combat.rng.Next(minDamage, maxDamage + 1);
            float firstDamage = successes * (Combat.rng.Next(minDamage, maxDamage + 1));
            float secondDamage = (firstDamage * user.tempAttack * user.tempAttack) / (user.tempAttack * targets[0].tempDefense);
            //roll for total damage - defense
            return secondDamage;
        }

        float criticalHit(float dmg)
        {
            float totalDamage = dmg * criticalDamage;
            return totalDamage;
        }

        float resistDamage(float dmg)
        {
            float totalDamage = 0f;
            int resistance = 0;
            //get string of skills elemental type
            foreach (KeyValuePair<string, int> resist in targets[0].resistances)
            {
                if (resist.Key == element)
                {
                    resistance = resist.Value;
                    //get the value of the resistance of the target
                }
            }
            totalDamage = dmg + (dmg * (resistance/100f));
            //check all of the targets resistances, edit dmg accordingly
            return totalDamage;
        }

    } //end skill class

}
