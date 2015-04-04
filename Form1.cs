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

        //internal List<Control> resistanceLabels;

        public CharacterForm(Character character)
        {
            InitializeComponent();
            Location = MousePosition;

            player = character;

            setStats();
            getWeapons();
            getEquipment();
            getResists();
            displayStats();

        }

        private void getWeapons()
        {
            weapon1.Text = null;
            weapon2.Text = null;
            if (player.weapons.Count > 0) { weapon1.Text = player.weapons[0]; }
            if (player.weapons.Count > 1) { weapon2.Text = player.weapons[1]; }

        }

        private void getEquipment()
        {
            accessory1.Text = null;
            accessory2.Text = null;
            if (player.equipment.Count > 0) { accessory1.Text = player.equipment[0]; }
            if (player.equipment.Count > 1) { accessory2.Text = player.equipment[1]; }
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

        private void getResists(){
           /*foreach(var element in player.resistances){
               foreach (Control c in resistanceLabels)
               {
                   if (c.Name.Contains(element.Key))
                   {
                       c.Text = element.Value.ToString();
                   }
               }
           }*/
            foreach (var element in player.resistances)
            {
                switch (element.Key)
                {
                    case "fire":
                        fireResist.Text = element.Value.ToString();
                        break;
                    case "water":
                        waterResist.Text = element.Value.ToString();
                        break;
                    case "ice":
                        iceResist.Text = element.Value.ToString();
                        break;
                    case "earth":
                        earthResist.Text = element.Value.ToString();
                        break;
                    case "wind":
                        windResist.Text = element.Value.ToString();
                        break;
                    case "electric":
                        electricResist.Text = element.Value.ToString();
                        break;
                    case "poison":
                        poisonResist.Text = element.Value.ToString();
                        break;
                    case "dark":
                        darkResist.Text = element.Value.ToString();
                        break;
                    case "light":
                        lightResist.Text = element.Value.ToString();
                        break;
                    default:
                        break;
                 
                }
            }
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

        private void CharacterForm_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
