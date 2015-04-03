using System;
using System.Collections.Generic;

namespace battleTest
{
    public class BattleControl
    {
        internal int turnCounter;
        internal List<Character> allCharacters;
        internal Character currentCharacter;

        internal battle mainForm; 

        public BattleControl(battle parentForm)
        {
            mainForm = parentForm;

            allCharacters = new List<Character>();
            allCharacters.Add(new Character("test"));
            allCharacters.Add(new Character("enemy"));

            allCharacters.Sort(delegate(Character p1, Character p2)
            {
                return p1.tempSpeed.CompareTo(p2.tempSpeed);
            } );

            findTurn();
            //load characters
            //determine turn order
            //start first turn
        }

        public void update()
        {
            mainForm.setStats();
        }

        public void findTurn(){
            if(turnCounter == allCharacters.Count-1){
                turnCounter = 0;
            }
            else
            {
                turnCounter++;
            }
            startTurn();
        }

        void startTurn()
        {
            currentCharacter = allCharacters[turnCounter];
            Combat.output(allCharacters[turnCounter].activateStatus());
            Combat.output("Beginning turn of " + currentCharacter.Name + "...");
            mainForm.getSkills(currentCharacter);
        }

        public void useSkill(Character c, int s)
        {
            //c.useSkill(s);
            //output(c.name + " used " + c.skills[s] + ".");
            targetDialog targetting = new targetDialog(c.skills[s],mainForm);
            targetting.Show();
            //List<Character> targets = new List<Character>();
            //targets.Add(allCharacters[0]);
            //c.skills[s].use(c,targets);
            //findTurn();
        }

        public void getTargets(Skill sk, List<Character> dialogTargets)
        {
            Combat.output(dialogTargets.Count.ToString()+" Targets recieved!");
            if (sk.use(currentCharacter, dialogTargets))
            {
                //if the skill was used successfully, find the next turn.
                update();
                findTurn();
            }
        }

    }

}
