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
    public partial class targetDialog : Form
    {
        Skill skill;
        battle parent;

        bool charSelectMode = false;

        public targetDialog(List<string> choices, battle mainForm)
        {
            //use as a character select dialog at beginning of battle
            parent = mainForm;

            InitializeComponent();

            Text = "Character Selection:";
            charSelectMode = true;
            foreach (string c in choices)
            {
                targetList.Items.Add(c);
            }

        }

        public targetDialog(Skill sk, battle mainForm)
        {
            skill = sk;
            parent = mainForm;

            InitializeComponent();            

            findTargets();
            setTargettingMode();
        }

        private void findTargets()
        {
            List<Character> targets = parent.BC.allCharacters;
            //find and populate the target list with the correct list of Characters
            foreach (Character c in targets)
            {
                if (skill.targetGroup == "enemies")
                {
                    if (c.team != parent.BC.currentCharacter.team)
                    {
                        targetList.Items.Add(c);
                    }
                }
                if (skill.targetGroup == "allies")
                {
                    if (c.team == parent.BC.currentCharacter.team)
                    {
                        targetList.Items.Add(c);
                    }
                }
            }

        }

        private void setTargettingMode()
        {
            if (skill.targetNumber == "all")
            {
                for (int t = 0; t < targetList.Items.Count; t++)
                {
                    targetList.SetItemChecked(t, true);
                }
                targetList.Enabled = false;
            }
            if (skill.targetNumber == "single" && targetList.Items.Count == 1)
            {
                targetList.SetItemChecked(0, true);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (charSelectMode)
            {
                List<string> finalTargets = new List<string>();

                foreach (string c in targetList.CheckedItems)
                {
                    finalTargets.Add(c);
                }
                if (finalTargets.Count < 1) { return; }
                //return list to a proc that adds characters to the battle
                Console.WriteLine("Adding character " + finalTargets[0]);
                parent.BC.addCharacter(finalTargets[0]);
                this.Close();
            }
            else
            {
                List<Character> finalTargets = new List<Character>();

                foreach (Character c in targetList.CheckedItems)
                {
                    finalTargets.Add(c);
                }
                if (finalTargets.Count < 1) { return; }
                parent.BC.getTargets(skill, finalTargets);
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void targetDialog_Load(object sender, EventArgs e)
        {
            this.targetList.Location = new System.Drawing.Point(3, 3);
            this.targetList.CheckOnClick = true;
            this.targetList.DisplayMember = "Name";
            this.targetList.Size = new System.Drawing.Size(280, 180);

            this.Controls.Add(targetList);
        }

        private void targetList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(charSelectMode)
            { 
                for (int t = 0; t < targetList.Items.Count; t++)
                {
                    if (e.Index != t)
                    {
                        targetList.SetItemChecked(t, false);
                    }
                }
            }
            else if (skill.targetNumber == "single")
            {
                for (int t = 0; t < targetList.Items.Count; t++)
                {
                    if (e.Index != t)
                    {
                        targetList.SetItemChecked(t, false);
                    }
                }
            }
        }
    }
}
