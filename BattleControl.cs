using System;
using System.Collections.Generic;
using Ini;

namespace battleTest
{
    public class BattleControl
    {
        internal int turnCounter = 0;
        internal List<Character> allCharacters;
        internal Character currentCharacter;

        internal List<Character> PCS;
        internal List<Character> NPCS;

        internal battle mainForm;

        public bool inBattle= false;

        public BattleControl(battle parentForm, string sceneName, string playerName)
        {
            mainForm = parentForm;

            loadPlayer(playerName);
            loadScene(sceneName);

        }

        public bool loadScene(string sceneName)
        {
            //Console.WriteLine("opening scene " + sceneName);
            IniFile newScene = new IniFile("../../"+sceneName+".seen");
            string sceneTitle = newScene.IniReadValue(sceneName,"title");
            //Console.WriteLine("This title is: " + sceneTitle);
            string players = newScene.IniReadValue(sceneName, "players");
            string wave1 = newScene.IniReadValue(sceneName, "wave1");
            string wave2 = newScene.IniReadValue(sceneName, "wave2");
            //texture background = newScene.IniReadValue(sceneName,"background");

            allCharacters = new List<Character>();
            PCS = new List<Character>();
            NPCS = new List<Character>();

            string[] pcs = players.Split(new string[] { "," }, System.StringSplitOptions.None);
            //Console.WriteLine(players);
            for (int p = 0; p < pcs.Length; p++)
            {
                //Console.WriteLine("Adding character " + pcs[p]);
                Character newPC = new Character(pcs[p]);
                allCharacters.Add(newPC);
                PCS.Add(newPC);
            }
            string[] firstWave = wave1.Split(new String[] { "," }, System.StringSplitOptions.None);
            for (int e = 0; e < firstWave.Length; e++)
            {
               // Console.WriteLine("Adding character " + firstWave[e]);
                Character newNPC = new Character(firstWave[e]);
                allCharacters.Add(newNPC);
                NPCS.Add(newNPC);
            }

            mainForm.Text = sceneTitle;

           return true;
        }

        public void loadPlayer(string playerInfo)
        {
            IniFile playerFile = new IniFile("../../" + playerInfo + ".sav");
            string reserve = playerFile.IniReadValue(playerInfo, "party");

            string[] party = reserve.Split(new string[] { "," }, System.StringSplitOptions.None);
            mainForm.partyCharacters = new List<string>();
            for (int p = 0; p < party.Length; p++)
            {
                mainForm.partyCharacters.Add(party[p]);
            }

        }

        public void addCharacter(string character)
        {
            //
            Character nChar = new Character(character);
            //Console.WriteLine("Created character " + character);
            allCharacters.Add(nChar);
            PCS.Add(nChar);
            mainForm.partyCharacters.Remove(character);

            mainForm.findTeams();
            mainForm.setStats();
        }

        public void startCombat()
        {
            inBattle = true;
            allCharacters.Sort(delegate(Character p1, Character p2)
            {
                return p2.tempSpeed.CompareTo(p1.tempSpeed);
            });

            //sort the characters by their speed stat so that the fastest goes first
            //find and start the first turn of combat
            //findTurn();
            startTurn();
        }

        public void update()
        {

            mainForm.setStats();
        }

        public void findTurn(){

            currentCharacter.removeOldStatus();
            update();

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
            //Combat.output(allCharacters[turnCounter].activateStatus());
            if (currentCharacter.team == "player")
            {
                Combat.output("Beginning turn of " + currentCharacter.Name + "...", bold: true, textColor: System.Drawing.Color.DodgerBlue);
            }
            else
            {
                Combat.output("Beginning turn of " + currentCharacter.Name + "...", bold: true, textColor: System.Drawing.Color.Firebrick);

            }
            currentCharacter.activateStatus("turn");
            currentCharacter.checkSkills();
            if (currentCharacter.behavior != null)
            {
               // Console.WriteLine("We see you are an AI "+currentCharacter.Name);
                currentCharacter.behavior.startAITurn(this);
                return;
            }
            mainForm.getSkills(currentCharacter);
            //activating all of the status, pass what turn step it is
            
            update();
        }

        public void useSkill(Character c, int s)
        {
            targetDialog targetting = new targetDialog(c.skills[s],mainForm);
            targetting.Show();
        }

        public void rest(Character c)
        {
            c.rest();
            update();
            findTurn();
        }

        public void getTargets(Skill sk, List<Character> dialogTargets)
        {
            //Combat.output(dialogTargets.Count.ToString()+" Targets recieved!");
            if (sk.use(currentCharacter, dialogTargets))
            {
                //if the skill was used successfully, find the next turn.
                update();
                findTurn();
            }
        }

    }

}
