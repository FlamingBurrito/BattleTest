using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battleTest
{
    public partial class battle : Form
    {
        internal List<Character> player;
        internal List<Character> enemy;

        internal List<string> partyCharacters;

        internal BattleControl BC;

        public battle(string sceneName, string playerName)
        {
            InitializeComponent();

            Combat.setForm(this);


            BC = new BattleControl(this,sceneName,playerName);
            findTeams();                         

            setStats();

        }

        public void findTeams()
        {
            player = new List<Character>();
            enemy = new List<Character>();

            for (int c = 0; c < BC.allCharacters.Count; c++)
            {
                if (BC.allCharacters[c].team == "player")
                {
                    //Console.WriteLine("Adding " + BC.allCharacters[c].Name + " to players team");
                    player.Add(BC.allCharacters[c]);
                }
                else
                {
                    foreach (Character e in enemy)
                    {
                        if (e.Name == BC.allCharacters[c].Name)
                        {
                            BC.allCharacters[c].Name += (" " + c.ToString());
                        }
                    }
                    enemy.Add(BC.allCharacters[c]);
                }
            }
        }

        public void getSkills(Character c)
        {
            skillButton1.Text = c.skills[0].Name;
            skillButton2.Text = c.skills[1].Name;
        }

        public void setStats()
        {
            
            labelPlayer1Energy.Text = "energy: "+player[0].MP.ToString();
            labelPlayer1Health.Text = "health: "+player[0].HP.ToString();
            Player1.Text = player[0].Name;
            
            labelNPC1Energy.Text = "energy: " + enemy[0].MP.ToString();
            labelNPC1Health.Text = "health: " + enemy[0].HP.ToString();
            NPC1.Text = enemy[0].Name;

            if (player.Count > 1)
            {
                labelPlayer2Energy.Text = "energy: " + player[1].MP.ToString();
                labelPlayer2Health.Text = "health: " + player[1].HP.ToString();
                Player2.Text = player[1].Name;
            }

            if (player.Count > 2)
            {
                labelPlayer3Energy.Text = "energy: " + player[2].MP.ToString();
                labelPlayer3Health.Text = "health: " + player[2].HP.ToString();
                Player3.Text = player[2].Name;
            }

            if (enemy.Count > 1)
            {
                labelNPC2Energy.Text = "energy: " + enemy[1].MP.ToString();
                labelNPC2Health.Text = "health: " + enemy[1].HP.ToString();
                NPC2.Text = enemy[1].Name;
            }
            if (enemy.Count > 2)
            {
                labelNPC3Energy.Text = "energy: " + enemy[2].MP.ToString();
                labelNPC3Health.Text = "health: " + enemy[2].HP.ToString();
                NPC3.Text = enemy[2].Name;
            }
            displayStatus();
            
        }

        private void displayStatus()
        {
            labelPlayer1Status.Text = null;
            labelPlayer2Status.Text = null;
            labelPlayer3Status.Text = null;
            labelNPC1Status.Text = null;
            labelNPC2Status.Text = null;
            labelNPC3Status.Text = null;

            foreach (Status s in player[0].statuses)
            {
                labelPlayer1Status.Text +=(" " + s.Name);
            }
            if (player.Count > 1)
            {
                foreach (Status s in player[1].statuses)
                {
                    labelPlayer2Status.Text += " " + s.Name;
                }
            }
            if (player.Count > 2) { 
                foreach (Status s in player[2].statuses)
                {
                    labelPlayer3Status.Text += " " + s.Name;
                }
            }
            foreach (Status s in enemy[0].statuses)
            {
                labelNPC1Status.Text += (" " + s.Name);
            }
            if (enemy.Count > 1)
            {
                foreach (Status s in enemy[1].statuses)
                {
                    labelNPC2Status.Text += " " + s.Name;
                }
            }
            if (enemy.Count > 2)
            {
                foreach (Status s in enemy[2].statuses)
                {
                    labelNPC3Status.Text += " " + s.Name;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text += BC.currentCharacter.name+" attacked.\n";
            //BC.currentCharacter.useSkill(1);
            BC.useSkill(BC.currentCharacter, 0);
            setStats();
            //BC.findTurn();
            //richTextBox1.Text += "starting turn " + BC.allCharacters[BC.turnCounter].name+"\n";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            CharacterForm nForm = new CharacterForm(player[0]);
            nForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CharacterForm nForm = new CharacterForm(enemy[0]);
            nForm.Show();
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            if (BC.inBattle && player.Count > 1)
            {//battle is started and there should be a character here
                CharacterForm nForm = new CharacterForm(player[1]);
                nForm.Show();
            }
            if(!BC.inBattle)
            {
                targetDialog nForm = new targetDialog(partyCharacters, this);
                nForm.Show();
            }
            
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (BC.inBattle)
            {
                //open up the menu dialog for saving, editing, etc
                debub debugMenu = new debub(BC);
                debugMenu.Show();
            }
            else
            {
                BC.startCombat();
                MenuButton.Text = "Menu";
            }
            
        }

        private void Player3_Click(object sender, EventArgs e)
        {
            if (BC.inBattle && player.Count > 2)
            {//battle is started and there should be a character here
                CharacterForm nForm = new CharacterForm(player[2]);
                nForm.Show();
            }
            if(!BC.inBattle)
            {
                targetDialog nForm = new targetDialog(partyCharacters, this);
                nForm.Show();
            }
        }

        private void NPC2_Click(object sender, EventArgs e)
        {
          CharacterForm nForm = new CharacterForm(enemy[1]);
          nForm.Show();
            
        }

        private void NPC3_Click(object sender, EventArgs e)
        {
           CharacterForm nForm = new CharacterForm(enemy[2]);
           nForm.Show();
            
        }

        private void skillButton2_Click(object sender, EventArgs e)
        {
            BC.useSkill(BC.currentCharacter, 1);
            setStats();
        }
    }
}
