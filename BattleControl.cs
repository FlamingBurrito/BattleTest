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
            Combat.output("Beginning turn of " + currentCharacter.name + "...");
            mainForm.getSkills(currentCharacter);
        }

        public void useSkill(Character c, byte s)
        {
            //c.useSkill(s);
            //output(c.name + " used " + c.skills[s] + ".");
            List<Character> targets = new List<Character>();
            targets.Add(allCharacters[0]);
            c.skills[s].use(c,targets);
        }

    }

}
