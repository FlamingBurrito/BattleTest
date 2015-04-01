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
        internal Character player = null;
        internal Character enemy = null;

        internal BattleControl BC;

        internal List<int> rolls;

        public battle()
        {
            InitializeComponent();

            Combat.setForm(this);

            BC = new BattleControl(this);

            

            rolls = new List<int>();
            findTeams();

            labelChar1Name.Text = player.name;
            labelChar1Status.Text = "";
            foreach (string s in player.statuses)
            {
                labelChar1Status.Text += s;
            }

            labelChar2Name.Text = enemy.name;
            labelChar2Status.Text = "";
            foreach (string s in enemy.statuses)
            {
                labelChar2Status.Text += s;
            }

            setStats();
        }

        void findTeams()
        {
            foreach(Character c in BC.allCharacters){
                if (c.team == "player")
                {
                    player = c;
                }
                else
                {
                    enemy = c;
                }
            }
        }

        public void getSkills(Character c)
        {
            skillButton1.Text = c.skills[0].skillName;
            skillButton2.Text = c.skills[1].skillName;
        }

        void setStats()
        {
            labelChar1Accuracy.Text = "accuracy: "+player.tempAccuracy.ToString();
            labelChar1Attack.Text = "attack: "+player.tempAttack.ToString();
            labelChar1Defense.Text = "defense: "+player.tempDefense.ToString();
            labelChar1Energy.Text = "energy: "+player.tempStamina.ToString();
            labelChar1Evasion.Text = "evasion: "+player.tempEvasion.ToString();
            labelChar1Health.Text = "health: "+player.tempHealth.ToString();
            labelChar1Magic.Text = "magic: "+player.tempSpirit.ToString();
            labelChar1Spirit.Text = "spirit: "+player.tempWill.ToString();

            labelChar2Accuracy.Text = "accuracy: " + enemy.tempAccuracy.ToString();
            labelChar2Attack.Text = "attack: " + enemy.tempAttack.ToString();
            labelChar2Defense.Text = "defense: " + enemy.tempDefense.ToString();
            labelChar2Energy.Text = "energy: " + enemy.tempStamina.ToString();
            labelChar2Evasion.Text = "evasion: " + enemy.tempEvasion.ToString();
            labelChar2Health.Text = "health: " + enemy.tempHealth.ToString();
            labelChar2Magic.Text = "magic: " + enemy.tempSpirit.ToString();
            labelChar2Spirit.Text = "spirit: " + enemy.tempWill.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text += BC.currentCharacter.name+" attacked.\n";
            //BC.currentCharacter.useSkill(1);
            BC.useSkill(BC.currentCharacter, 0);
            //BC.findTurn();
            //richTextBox1.Text += "starting turn " + BC.allCharacters[BC.turnCounter].name+"\n";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }


        private void bCount_Click(object sender, EventArgs e)
        {
            //Combat.rollDice(5,10);
            //Combat.countSuccesses(rolls, 5);
            //Combat.getDamage(Combat.countSuccesses(rolls, 5));            
            int dice = Convert.ToInt32(tbDice.Text);
            int sides = Convert.ToInt32(tbSides.Text);
            int target = Convert.ToInt32(tbTarget.Text);
            Combat.getDamage(Combat.countSuccesses(Combat.rollDice(dice, sides), target));
        }
    }
}
