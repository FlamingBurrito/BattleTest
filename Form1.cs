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
    public partial class CharacterForm : Form
    {
        internal Character player;

        public CharacterForm(Character character)
        {
            InitializeComponent();
            Location = MousePosition;

            player = character;

            setStats();
            displayStats();

        }

        private void setStats()
        {
            PBHealth.Value = player.tempHealth;
            PBStamina.Value = player.tempStamina;

            PBSpeed.Value = player.tempSpeed;
            PBAttack.Value = player.tempAttack;
            PBAccuracy.Value = player.tempAccuracy;
            PBSpirit.Value = player.tempSpirit;
            PBDefense.Value = player.tempDefense;
            PBEvasion.Value = player.tempEvasion;
            PBWill.Value = player.tempWill;
        }

        private void displayStats()
        {
            healthNum.Text = "("+player.tempHealth.ToString()+")";
            staminaNum.Text = "(" + player.tempStamina.ToString() + ")";

            speedNum.Text = "(" + player.tempSpeed.ToString() + ")";
            attackNum.Text = "(" + player.tempAttack.ToString() + ")";
            accuracyNum.Text = "(" + player.tempAccuracy.ToString() + ")";
            spiritNum.Text = "(" + player.tempSpirit.ToString() + ")";
            defenseNum.Text = "(" + player.tempDefense.ToString() + ")";
            evasionNum.Text = "(" + player.tempEvasion.ToString() + ")";
            willNum.Text = "(" + player.tempWill.ToString() + ")";
        }
    }
}
