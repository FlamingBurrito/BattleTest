using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ini;

namespace battleTest
{
    public class Status
    {
        public string Name { get; set; }
        public string type;	//boon, ailment, intrinsic
        public string step;	//when it activates during a turn

        public string description;

        public Character owner;

        public int stack { get; set; }	//how many can be stacked
        public int count { get; set; }	//how many are currently on character

        public int length { get; set; }	//how long it will last, in turns
        public int turns { get; set; }	//how many turns it has been around

        internal string functions;

        public int activateChance;

        public Status(Character newOwner, string newStatus)
        {
            owner = newOwner;
            IniFile newFile = new IniFile("../../" + newStatus + ".stat");
            Console.WriteLine("Loading status " + newStatus);
            loadStatus(newFile);
        }

        public void loadStatus(IniFile currentFile)
        {
            string statusName = System.IO.Path.GetFileNameWithoutExtension(currentFile.path);
            Console.WriteLine("setting up status " + statusName);
            //use path operation to get the section name of the status
            Name = currentFile.IniReadValue(statusName, "name");
            step = currentFile.IniReadValue(statusName, "step");
            type = currentFile.IniReadValue(statusName, "type");

            description = currentFile.IniReadValue(statusName, "desc");


            functions = currentFile.IniReadValue(statusName, "function");

            string[] commands = functions.Split(new string[] { ";" }, System.StringSplitOptions.None);

            activateChance = Convert.ToInt32(currentFile.IniReadValue(statusName, "activateChance"));
            stack = Convert.ToInt32(currentFile.IniReadValue(statusName, "stack"));
            length = Convert.ToInt32(currentFile.IniReadValue(statusName, "length"));


        }

        public virtual void added(Character owner)
        {

        }

        public void readFunction()
        {
            string[] commands = functions.Split(new string[] { ";" }, System.StringSplitOptions.None);
            for (int i = 0; i < commands.Length; i++)
            {
                string[] args = commands[i].Split(new string[] { "," }, System.StringSplitOptions.None);
                if (args[0] == "harm")
                {
                    harm(Convert.ToInt32(args[1]), args[2]);
                }
            }
            /*
              absorbDamage(#absorbed, from skillType)
        activate(skillName or skillType)
        addArmor(# to add, vs skillType)
        addDamage(% to increase, of skillType)
        addResist(# to change, resistance)
        addStat(# to change, stat to change)
        addStatus(% chance,status to add,target,onEnd?)
        evasion(% chance, to evade skillType)
        Harm(% to harm, health/stamina)
        Heal(% to heal, health/stamina)
        protect(% chance to protect, from skillType)
        response(skill to use, target)
             */
        }

        public virtual void activate()
        {
            if (Combat.rollCheck(activateChance, 101))
            {		//skill activates
                readFunction();
            }
            else
            {
                return;
            }
        }

        void harm(int percent, string element){
            owner.damage(percent, element, true);
            Combat.output("Poison Activates on " + owner.Name);
        }

        public virtual void remove(Character owner)
        {
        }


    }

}
