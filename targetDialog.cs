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
        public targetDialog(Skill sk)
        {
            skill = sk;

            InitializeComponent();

            findTargets();
            setTargettingMode();
        }

        private void findTargets()
        {
            //find and populate the target list with the correct list of Characters
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
    }
}
