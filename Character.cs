using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ini;

namespace battleTest
{
    public class Character
    {
        internal string name;

        internal string team;

        internal float attack {get; set;}
        internal float accuracy { get; set; }
        internal float spirit { get; set; }
        internal float defense { get; set; }
        internal float evasion { get; set; }
        internal float will { get; set; }

        internal float speed;
        internal float health;
        internal float stamina;

        internal int maxHP;
        internal int HP;
        internal int maxMP;
        internal int MP;

        internal int tempAttack;
        internal int tempAccuracy;
        internal int tempSpirit;
        internal int tempDefense;
        internal int tempEvasion;
        internal int tempWill;

        internal int tempSpeed;
        internal int tempHealth;
        internal int tempStamina;

        internal List<Skill> skills;

        internal List<KeyValuePair<string, int>> resistances;

        internal List<string> statuses;
        internal List<string> intrinsics;
        internal List<string> equipment;
        internal List<string> inventory;
        internal List<string> weapons;

        public Character(string charFile)
        {
            load(charFile);
        }

        public void load(string CharFile){

            IniFile newFile = new IniFile("../../"+CharFile+".char");
            //string charName = Path.GetFileNameWithoutExtension(newFile.path);

            name = newFile.IniReadValue(CharFile,"name");
            team = newFile.IniReadValue(CharFile, "team");
            attack = float.Parse(newFile.IniReadValue(CharFile, "attack"));
            accuracy = float.Parse(newFile.IniReadValue(CharFile, "accuracy"));
            spirit = float.Parse(newFile.IniReadValue(CharFile, "spirit"));
            defense = float.Parse(newFile.IniReadValue(CharFile, "defense"));
            evasion = float.Parse(newFile.IniReadValue(CharFile, "evasion"));
            will = float.Parse(newFile.IniReadValue(CharFile, "will"));

            speed = float.Parse(newFile.IniReadValue(CharFile, "speed"));
            health = float.Parse(newFile.IniReadValue(CharFile, "health"));
            stamina = float.Parse(newFile.IniReadValue(CharFile, "stamina"));

            resistances = new List<KeyValuePair<string,int>>();

            resistances.Add(new KeyValuePair<string,int>(
                "fire",Convert.ToInt32(newFile.IniReadValue(CharFile,"resistFire"))));
            resistances.Add(new KeyValuePair<string, int>(
                "ice", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistIce"))));
            resistances.Add(new KeyValuePair<string, int>(
                "water", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistWater"))));
            resistances.Add(new KeyValuePair<string, int>(
                "earth", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistEarth"))));
            resistances.Add(new KeyValuePair<string, int>(
                "wind", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistWind"))));
            resistances.Add(new KeyValuePair<string, int>(
                "electric", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistElectric"))));
            resistances.Add(new KeyValuePair<string, int>(
                "poison", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistPoison"))));
            resistances.Add(new KeyValuePair<string, int>(
                "dark", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistDark"))));
            resistances.Add(new KeyValuePair<string, int>(
                "light", Convert.ToInt32(newFile.IniReadValue(CharFile, "resistLight"))));

            char[] seperator = new char[] { ',' };

            skills = new List<Skill>();
            string skillsList = newFile.IniReadValue(CharFile, "skills");
            string[] newSkills = skillsList.Split(seperator, StringSplitOptions.None);
            for (int s = 0; s < newSkills.Length; s++)
            {
                Skill newSkill = new Skill(newSkills[s]);
                skills.Add(newSkill);
            }

            intrinsics = new List<string>();
            string intrinsicList = newFile.IniReadValue(CharFile, "intrinsics");
            string[] newIntrinsic = intrinsicList.Split(seperator, StringSplitOptions.None);
            for (int n = 0; n < newIntrinsic.Length; n++)
            {
                intrinsics.Add(newIntrinsic[n]);
            }

                statuses = new List<string>();
            string status = newFile.IniReadValue(CharFile, "status");
            string[] newStatuses = status.Split(seperator, StringSplitOptions.None);
            for (int t = 0; t < newStatuses.Length; t++)
            {
                statuses.Add(newStatuses[t]);
            }

            equipment = new List<string>();
            string equips = newFile.IniReadValue(CharFile, "equipment");
            string[] newEquips = equips.Split(seperator, StringSplitOptions.None);
            for (int e = 0; e < newEquips.Length; e++)
            {
                equipment.Add(newEquips[e]);
            }

            weapons = new List<string>();
            string weapon = newFile.IniReadValue(CharFile, "weapons");
            string[] newWeapon = weapon.Split(seperator, StringSplitOptions.None);
            for (int w = 0; w < newWeapon.Length; w++)
            {
                weapons.Add(newWeapon[w]);
            }

            inventory = new List<string>();
            string items = newFile.IniReadValue(CharFile, "inventory");
            string[] newItems = items.Split(seperator, StringSplitOptions.None);
            for (int i = 0; i < newItems.Length; i++)
            {
                inventory.Add(newItems[i]);
            }

                setStats();
        }

        internal void setStats()
        {
           /* tempAttack = Convert.ToInt32(Math.Ceiling(attack * 100));
            tempAccuracy = Convert.ToInt32(Math.Ceiling(accuracy * 100));
            tempSpirit = Convert.ToInt32(Math.Ceiling(spirit * 100));
            tempDefense = Convert.ToInt32(Math.Ceiling(defense * 100));
            tempEvasion = Convert.ToInt32(Math.Ceiling(evasion * 100));
            tempWill = Convert.ToInt32(Math.Ceiling(will * 100));
            tempSpeed = Convert.ToInt32(Math.Ceiling(speed * 100));
            tempHealth = Convert.ToInt32(Math.Ceiling(health * 100));
            tempStamina = Convert.ToInt32(Math.Ceiling(stamina * 100));*/

            tempAttack = Convert.ToInt32(Math.Ceiling(attack));
            tempAccuracy = Convert.ToInt32(Math.Ceiling(accuracy));
            tempSpirit = Convert.ToInt32(Math.Ceiling(spirit));
            tempDefense = Convert.ToInt32(Math.Ceiling(defense));
            tempEvasion = Convert.ToInt32(Math.Ceiling(evasion));
            tempWill = Convert.ToInt32(Math.Ceiling(will));
            tempSpeed = Convert.ToInt32(Math.Ceiling(speed));
            tempHealth = Convert.ToInt32(Math.Ceiling(health));
            tempStamina = Convert.ToInt32(Math.Ceiling(stamina));

            maxHP = tempHealth*100; maxMP = tempStamina*100;
            HP = maxHP; MP = maxMP;
        }

        public string activateStatus()
        {
            string returnString = null;

            foreach(string c in statuses){
                if (c.Length > 1) 
                { 
                returnString += c + " activated on " + name;
                }
            }

            return returnString;
        }

        public void useSkill(int snum){
            Combat.output("skill number " + snum.ToString() + " used");
        }

        public void damage(float dmg, string element, bool flag)
        {
            int damage = Convert.ToInt32(Math.Ceiling(dmg));
            HP -= damage;
            Combat.output("I took " + damage.ToString() + " " + element + " damage!");
        }

        public void addStatus(string status)
        {
            //add a status to the characters status list
        }


    }
}
