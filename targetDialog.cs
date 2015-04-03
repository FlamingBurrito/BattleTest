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
                if (skill.targetGroup == "allEnemies" || skill.targetGroup == "singleEnemy")
                {
                    if (c.team != parent.BC.currentCharacter.team)
                    {
                        targetList.Items.Add(c);
                    }
                }
                if (skill.targetGroup == "allAllies" || skill.targetGroup == "singleAlly")
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
            if (skill.targetGroup == "allEnemies" || skill.targetGroup == "allAllies")
            {
                //set multiselect, select all of chosen group
                targetList.SelectionMode = SelectionMode.MultiSimple;
            }
            else
            {
                //set single select, do not select any character
                targetList.SelectionMode = SelectionMode.One;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Character> finalTargets = new List<Character>();

            foreach (Character c in targetList.CheckedItems)
            {
                finalTargets.Add(c);
            }

            if (finalTargets.Count < 1) { return; }

            parent.BC.getTargets(skill,finalTargets);
            this.Close();
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
    }
}
