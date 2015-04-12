using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleTest
{
    class AI
    {
        //ferocity (all out attack, somewhat defense, etc)
        //type of skills (boosts, attacks, etc)
        //who they attack (weakest, strongest, magic users, etc)
        //how likely they follow the best course of action
        enum Ferocity { Calm, Mild, Balanced, Fierce, Extreme };
        enum Target { Weakest, Strongest, MagicUser, Any };
        enum Natural { Offense, Defense, Support, Balanced };
        enum Intelligence { Chaotic, Low, Normal, High, Mastermind};

        Ferocity intensity;
        Target perferredTarget;
        Intelligence intelligence;
        Natural state;

        int defensePull;
        int offensePull;
        int supportPull;


        Skill skillToUse;
        List<Character> targets;

        Character owner;

        BattleControl BC;

        public AI(Character IAM)
        {
            intensity = Ferocity.Balanced;
            perferredTarget = Target.Any;
            state = Natural.Balanced;
            intelligence = Intelligence.Normal;
            owner = IAM;
        }

        public void startAITurn(BattleControl Battle)
        {
            //Console.WriteLine("starting AI turn.");
            BC = Battle;

            targets = new List<Character>();
            //determine skill
            determinePulls();
            checkPulls();

            skillToUse = decideSkill();

            if (skillToUse.targetNumber == "all")
            {   //skill just effects all of a side, so no need to determine target
                switch(skillToUse.targetGroup)
                {
                    case "enemies":
                        targets.AddRange(BC.PCS);
                        break;
                    case "allies":
                        targets.AddRange(BC.NPCS);
                        break;
                    case "self":
                        targets.Add(owner);
                        break;
                }
                skillToUse.use(owner, targets);
            }
            else
            {
                skillToUse.use(owner, findTarget());
            }
            //find targets

            //skillToUse.use(owner, findTarget());
            //use skill on targets
            
            BC.findTurn();
        }

        public void determinePulls()
        {
            defensePull = 0;
            offensePull = 0;
            supportPull = 0;

            getStatePull(); //adds to the pull of the natural state
            teamSize();

            offensePull += ferocity();
            defensePull += myHealth();
            supportPull += teammatesHealth();
            offensePull += enemiesHealth();

            Console.WriteLine(owner.Name+"'s offense pull is "+offensePull.ToString());
            Console.WriteLine(owner.Name + "'s defense pull is " + defensePull.ToString());
            Console.WriteLine(owner.Name + "'s support pull is " + supportPull.ToString());

            //checkPulls();
        }

        public string checkPulls()
        {
            if (offensePull > defensePull && offensePull > supportPull) { return "offense"; }
            else if (defensePull > offensePull && defensePull > supportPull) { return "defense"; }
            else if (supportPull > defensePull && supportPull > offensePull) { return "support";}
            else
            {
                switch (state)
                {
                    case Natural.Offense: return "offense";
                    case Natural.Defense: return "defense";
                    case Natural.Support: return "support";
                    default: return "offense";
                }
            }
        }

        public void getStatePull()
        {
            if (state == Natural.Offense) { offensePull++; }
            if (state == Natural.Defense) { defensePull++; }
            if (state == Natural.Support) { supportPull++; }
        }
        public int ferocity()
        {
            //Calm 0, Mild 1, Balanced 2, Fierce 3, Extreme 4
            return (int)intensity;
        }

        public int myHealth()
        {
            int healthPull = 0;
            if (owner.HP < (owner.maxHP * 0.75))
            {
                healthPull++;
            }
            if (owner.HP < (owner.maxHP * 50))
            {
                healthPull++;
            }
            if (owner.HP < (owner.maxHP * 25))
            {//low health, in bottom 1/4. Higher chance to be defensive.
                healthPull++;
            }
            return healthPull;
        }

        public int teammatesHealth()
        {
            int healthPull = 0;
            foreach (Character teammate in BC.NPCS)
            {
                if (teammate.HP < (teammate.maxHP * 0.33))
                {
                    healthPull++;
                }
            }
            return healthPull;
        }

        public int enemiesHealth()
        {
            int offensePull = 0;
            foreach (Character enemy in BC.PCS)
            {
                if (enemy.HP < (enemy.maxHP * 0.50)) { offensePull++; }
                if (enemy.HP < (enemy.maxHP * 033)) { offensePull++; }
            }
            return offensePull; 
        }

        public void teamSize()
        {
            if (BC.NPCS.Count > BC.PCS.Count)
            {
                //there are more teammates left than enemies be defensive
                defensePull++;
            }
            else
            {
                offensePull++;
            }
        }

        public List<Character> findTarget()
        {
            List<Character> possibleTargets = new List<Character>();
            if (skillToUse.targetGroup == "enemies") { possibleTargets.AddRange(BC.PCS); }
            if (skillToUse.targetGroup == "allies") { possibleTargets.AddRange(BC.NPCS); }
            if (skillToUse.targetGroup == "self") { possibleTargets.Add(owner); }

            List<Character> finalTarget = new List<Character>();

            switch (perferredTarget)
            {
                case Target.Any:
                    int randTarget = Combat.rng.Next(0, (possibleTargets.Count-1));
                    finalTarget.Add(possibleTargets[randTarget]);
                    break;
                case Target.Weakest:
                    //findWeakest(possibleTargets);
                    break;
                case Target.Strongest:
                    //findStrongest(possibleTargets);
                    break;
                case Target.MagicUser:
                    //findMagicUser(possibleTargets);
                    break;
            }
            return finalTarget;
        }


        public Skill decideSkill()
        {
            //if they are chaotic, 80% chance to use a random skill
            //if they have low intellegence, 50% chance to just use a random skill
            //if they are normal, 20% chance to use a random skill
            //if they are high 5% chance to use a random skill
            //if they are a manstermind, 2% chance to use a random skill
            List<Skill> possibleSkills = new List<Skill>();

            foreach (Skill s in owner.skills)
            {
                if (s.brand == checkPulls()) { possibleSkills.Add(s); }
            }
            //determine which pull is highest, if not random skill
            //select a skill from the characters skillset that matches pull
            //if no skill is found, just select a random one anyway
            int randomSkill = Combat.rng.Next(0, (possibleSkills.Count - 1));
            Skill skillToUse = possibleSkills[randomSkill];
            //owner.useSkill(0,targets);
            return skillToUse;
        }

        public bool testSkill()
        {
            //make sure that we have enough stamina to use skill
            //make sure that the skill is not in cooldown
            //make srue that there is a legal target for the skill
            //etc..
            return true;
        }


    }
}
