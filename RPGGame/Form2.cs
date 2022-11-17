using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGame
{
    public partial class Screen_LevelUp : Form
    {
        public static Screen_LevelUp instance;
        private int AttackDamage;
        private int AttackDamageAdded;

        private int MaxHealth;
        private int MaxHealthAdded;
        private int SkillpointsSpentOnHealth;

        private double Healing;
        private double HealingAdded;

        private int Armor;
        private int ArmorAdded;

        private int Crit;
        private int CritAdded;

        private int Luck;
        private int LuckAdded;


        public Screen_LevelUp()
        {
            InitializeComponent();
            instance = this;
        }

        private void Screen_LevelUp_Load(object sender, EventArgs e)
        {
            AttackDamage = Screen_Gameplay.instance.player.AttackDamage;
            MaxHealth = Screen_Gameplay.instance.player.MaxHealth;
            Healing = Screen_Gameplay.instance.player.HealPercentage;
            Armor = Screen_Gameplay.instance.player.Armor;
            Crit = Screen_Gameplay.instance.player.CritChance;
            Luck = Screen_Gameplay.instance.player.Luck;

            Btn_Add_Armor.Enabled = true;
            Btn_Add_AttackDamage.Enabled = true;
            Btn_Add_Health.Enabled = true;
            Btn_Add_Healing.Enabled = true;
            Btn_Add_Luck.Enabled = true;
            Btn_Add_Crit.Enabled = true;

            Label_AttackDamage.Text = "Attack Damage " + AttackDamage;
            Label_Health.Text = "Max.Health " + MaxHealth;
            Label_Healing.Text = "Healing " + Healing * 100 + "%";
            Label_Armor.Text = "Armor " + Armor;
            Label_Crit.Text = "Critical " + Crit;
            Label_Luck.Text = "Luck " + Luck;


            Btn_Done.Enabled = false;

        }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            Screen_Gameplay.instance.levelupScreenOpened = false;

            Screen_LevelUp.ActiveForm.Close();
        }

        private void Btn_Add_AttackDamage_Click(object sender, EventArgs e)
        {
            if(Screen_Gameplay.instance.player.Skillpoints > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints--;
                AttackDamageAdded += 2;
               
            }
            
        }

        private void Btn_Remove_AttackDamage_Click(object sender, EventArgs e)
        {
            if(AttackDamageAdded > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints++;
                AttackDamageAdded -= 2;
            }
            
        }

        private void Btn_Add_Health_Click(object sender, EventArgs e)
        {
            if(Screen_Gameplay.instance.player.Skillpoints > 0)
            {
                SkillpointsSpentOnHealth++;
                Screen_Gameplay.instance.player.Skillpoints--;
                MaxHealthAdded = 0;
                for (int i = 0; i < SkillpointsSpentOnHealth; i++)
                {
                    MaxHealthAdded += Convert.ToInt32((MaxHealth + MaxHealthAdded) * 0.1);
                }
            }
        }

        private void Btn_Remove_Health_Click(object sender, EventArgs e)
        {
            if (MaxHealthAdded > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints++;
                SkillpointsSpentOnHealth--;
                MaxHealthAdded = 0;
                for (int i = 0; i < SkillpointsSpentOnHealth; i++)
                {
                    MaxHealthAdded += Convert.ToInt32((MaxHealth + MaxHealthAdded) * 0.01);
                }
            }
        }

        private void Btn_Add_Healing_Click(object sender, EventArgs e)
        {
            if (Screen_Gameplay.instance.player.Skillpoints > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints--;
                HealingAdded += 0.05;
            }
        }

        private void Btn_Remove_Healing_Click(object sender, EventArgs e)
        {
            if (HealingAdded > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints++;
                HealingAdded -= 0.05;
            }
        }

        private void Btn_Add_Armor_Click(object sender, EventArgs e)
        {
            if (Screen_Gameplay.instance.player.Skillpoints > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints--;
                ArmorAdded += 5;
            }
        }

        private void Btn_Remove_Armor_Click(object sender, EventArgs e)
        {
            if (ArmorAdded > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints++;
                ArmorAdded -= 5;
            }
        }

        private void Btn_Add_Crit_Click(object sender, EventArgs e)
        {
            if (Screen_Gameplay.instance.player.Skillpoints > 0)
            {
                CritAdded++;
                Screen_Gameplay.instance.player.Skillpoints--;
            }
        }

        private void Btn_Remove_Crit_Click(object sender, EventArgs e)
        {
            if (CritAdded > 0)
            {
                Screen_Gameplay.instance.player.Skillpoints++;
                CritAdded --;
            }
        }

        private void Btn_Add_Luck_Click(object sender, EventArgs e)
        {
            if (Screen_Gameplay.instance.player.Skillpoints > 0)
            {
                LuckAdded++;
                Screen_Gameplay.instance.player.Skillpoints--;
            }
        }

        private void Btn_Remove_Luck_Click(object sender, EventArgs e)
        {
            if (LuckAdded !=0)
            {
                Screen_Gameplay.instance.player.Skillpoints++;
                LuckAdded--;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_Skillpoint.Text = Screen_Gameplay.instance.player.Skillpoints + "";
            Label_AddedValue_AttackDamage.Text = "+ " + AttackDamageAdded;
            Label_AddedValue_Health.Text = "+ " + MaxHealthAdded;
            Label_AddedValue_Healing.Text = "+ " + HealingAdded;
            Label_AddedValue_Armor.Text = "+ " + ArmorAdded;
            Label_AddedValue_Crit.Text = "+ " + CritAdded;
            Label_AddedValue_Luck.Text = "+ " + LuckAdded;
            
            Label_AttackDamage.Text = "Attack Damage " + AttackDamage;
            Label_Health.Text = "Max.Health " + MaxHealth;
            Label_Healing.Text = "Healing " + Healing * 100 + "%";
            Label_Armor.Text = "Armor " + Armor;
            Label_Crit.Text = "Critical " + Crit;
            Label_Luck.Text = "Luck " + Luck;

        }

        private void Btn_ApplySkillpoints_Click(object sender, EventArgs e)
        {
            Screen_Gameplay.instance.player.AttackDamage += AttackDamageAdded;
            AttackDamageAdded = 0;
            
            Screen_Gameplay.instance.player.MaxHealth += MaxHealthAdded;
            MaxHealthAdded = 0;
            
            Screen_Gameplay.instance.player.HealPercentage += HealingAdded;
            HealingAdded = 0;
            
            Screen_Gameplay.instance.player.Armor += ArmorAdded;
            ArmorAdded = 0;
            
            Screen_Gameplay.instance.player.CritChance += CritAdded;
            CritAdded = 0;
            
            Screen_Gameplay.instance.player.Luck += LuckAdded;
            LuckAdded = 0;

            AttackDamage = Screen_Gameplay.instance.player.AttackDamage;
            MaxHealth = Screen_Gameplay.instance.player.MaxHealth;
            Healing = Screen_Gameplay.instance.player.HealPercentage;
            Armor = Screen_Gameplay.instance.player.Armor;
            Crit = Screen_Gameplay.instance.player.CritChance;
            Luck = Screen_Gameplay.instance.player.Luck;
            if(Screen_Gameplay.instance.player.Skillpoints == 0)
            {
                Btn_Done.Enabled = true;
                Btn_Add_Armor.Enabled = false;
                Btn_Add_AttackDamage.Enabled = false;
                Btn_Add_Health.Enabled = false;
                Btn_Add_Healing.Enabled = false;
                Btn_Add_Luck.Enabled = false;
                Btn_Add_Crit.Enabled = false;
                SkillpointsSpentOnHealth = 0;
            }
        }
    }
}
