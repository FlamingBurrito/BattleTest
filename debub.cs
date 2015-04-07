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
    public partial class debub : Form
    {
        BattleControl BC;

        Character selChar;

        public debub(BattleControl battleC)
        {
            BC = battleC;

            InitializeComponent();
        }

        private void debub_Load(object sender, EventArgs e)
        {
            this.listCharacters.DisplayMember = "Name";
            this.statusList.DisplayMember = "Name";

            foreach (Character c in BC.allCharacters)
            {
                listCharacters.Items.Add(c);
            }

            loadAllStatus();
        }

        private void loadAllStatus()
        {
            string line;
            using (System.IO.StreamReader file = new System.IO.StreamReader("../../"+ "masterStatus.txt"))
                while ((line = file.ReadLine()) != null)
                {
                   cbAllStatus.Items.Add(line);
                }
            //open up the master status list and load it into the combobox
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listCharacters.SelectedItem != null)
            {
                selChar = BC.allCharacters[listCharacters.SelectedIndex];

                updateDebug();
            }
        }

        private void updateDebug()
        {
            if (listCharacters.SelectedItem != null)
            {

                labelHP.Text = selChar.HP.ToString();
                HPScroll.Value = selChar.HP;

                labelMP.Text = selChar.MP.ToString();
                MPScroll.Value = selChar.MP;

                labelAttack.Text = selChar.tempAttack.ToString();
                attackScroll.Value = selChar.tempAttack;

                labelAccuracy.Text = selChar.tempAccuracy.ToString();
                accuracyScroll.Value = selChar.tempAccuracy;

                labelSpirit.Text = selChar.tempSpirit.ToString();
                spiritScroll.Value = selChar.tempSpirit;

                labelDefense.Text = selChar.tempDefense.ToString();
                defenseScroll.Value = selChar.tempDefense;

                labelEvasion.Text = selChar.tempEvasion.ToString();
                evasionScroll.Value = selChar.tempEvasion;

                labelWill.Text = selChar.tempWill.ToString();
                willScroll.Value = selChar.tempWill;

                labelSpeed.Text = selChar.tempSpeed.ToString();
                speedScroll.Value = selChar.tempSpeed;

                statusList.Items.Clear();

                foreach (Status s in selChar.statuses)
                {
                    statusList.Items.Add(s);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BC.update();
            this.Close();
        }

        private void HPScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelHP.Text = HPScroll.Value.ToString();
            if (selChar != null) { selChar.HP = HPScroll.Value; }
            updateDebug();
        }

        private void MPScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelMP.Text = MPScroll.Value.ToString();
            if (selChar != null) { selChar.MP = MPScroll.Value; }
            updateDebug();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (statusList.SelectedItem != null)
            {
                selChar.statuses.RemoveAt(statusList.SelectedIndex);
                statusList.Items.RemoveAt(statusList.SelectedIndex);
            }

            updateDebug();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selChar != null && cbAllStatus.SelectedText != null)
            {
                selChar.addStatus(cbAllStatus.Text);
            }

            updateDebug();
            //add selected status to the player using character procs
            //refresh the statuslist to reflect the change
        }

        private void speedScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelSpeed.Text = speedScroll.Value.ToString();
            if (selChar != null) { selChar.tempSpeed = speedScroll.Value; }
            updateDebug();
        }

        private void attackScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelAttack.Text = attackScroll.Value.ToString();
            if (selChar != null) { selChar.tempAttack = attackScroll.Value; }
            updateDebug();
        }

        private void accuracyScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelAccuracy.Text = accuracyScroll.Value.ToString();
            if (selChar != null) { selChar.tempAccuracy = accuracyScroll.Value; }
            updateDebug();
        }

        private void spiritScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelSpirit.Text = spiritScroll.Value.ToString();
            if (selChar != null) { selChar.tempSpirit = spiritScroll.Value; }
            updateDebug();
        }

        private void defenseScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelDefense.Text = defenseScroll.Value.ToString();
            if (selChar != null) { selChar.tempDefense = defenseScroll.Value; }
            updateDebug();
        }

        private void evasionScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelEvasion.Text = evasionScroll.Value.ToString();
            if (selChar != null) { selChar.tempEvasion = evasionScroll.Value; }
            updateDebug();
        }

        private void willScroll_Scroll(object sender, ScrollEventArgs e)
        {
            labelWill.Text = willScroll.Value.ToString();
            if (selChar != null) { selChar.tempWill = willScroll.Value; }
            updateDebug();
        }
    }
}
