using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RPGGame;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace PlainTextRPG
{
    public class Player
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public int MaxExperience { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int CritChance { get; set; }
        public int Armor { get; set; }
        public double PercentageArmor { get; set; }
        public String Name { get; set; }
        public int MaxHealth { get; set; }
        public int EnemiesKilled { get; set; }
        public int Skillpoints { get; set; }
        public double HealPercentage { get; set; }
        public int Luck { get; set; }
        public int MissingHealth { get; set; }

        public bool IsDead;
        public bool levelupScreenOpened { get; set; } = false;


        //Default constructor
        public Player()
        {
            Level = 1;
            Experience = 0;
            MaxExperience = 30;
            MaxHealth = 100;
            Health = 100;
            AttackDamage = 40;
            CritChance = 10;
            Armor = 50;
            PercentageArmor = 0;
            Skillpoints = 0;
            HealPercentage = 0.1;
            Luck = 5;
            levelupScreenOpened = false;
            EnemiesKilled = 0;
        }

        public Player GainEXP(int EnemyLevel)
        {
            this.Experience += Convert.ToInt16(EnemyLevel * 10);
            
            
            return null;
        }
        public Player AttemptLevelUp()
        {
            int LevelBefore = this.Level;
            while (this.Experience >= this.MaxExperience)
            {
                this.Level++;
                this.Experience -= this.MaxExperience;
                this.Skillpoints += 3;
                this.MaxExperience = Convert.ToInt32(this.MaxExperience * 1.1);
                this.Health = this.MaxHealth;

            }
            if (!Screen_Gameplay.instance.levelupScreenOpened && LevelBefore != this.Level)
            {
                Debug.WriteLine("Opening LevelUp");
                Screen_Gameplay.instance.levelupScreenOpened = true;
                Screen_Gameplay.instance.levelupScreen.ShowDialog();
                
            }
            
            return null;
        }
        public Player TakeDamage(int IncomingDamage, bool EnemyDead)
        {
            if (EnemyDead)
            {

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The Enemy attacked with " + IncomingDamage + " Damage.\n");
                this.Health -= Convert.ToInt16(IncomingDamage - (IncomingDamage * 0.01 * this.PercentageArmor));
                Console.WriteLine("You have taken " + Convert.ToInt16(IncomingDamage - (IncomingDamage * 0.01 * this.PercentageArmor)) + " Damage from Enemy Attacks.\n");
                if (this.Health <= 0)
                {
                    this.IsDead = true;
                }

            }
            return null;

        }
        public Player Status()
        {
            Console.WriteLine();
            Console.WriteLine("             ______________________________");
            Console.WriteLine("             |Level " + this.Level + " " + this.Name + "´s Status:");
            Console.WriteLine("|HP          |" + this.Health + "/" + this.MaxHealth);
            Console.WriteLine("|Heal        |" + Convert.ToInt32(this.HealPercentage * 100) + "% (" + Convert.ToInt32(this.MaxHealth * this.HealPercentage) + ")");
            Console.WriteLine("|ATK         |" + this.AttackDamage);
            Console.WriteLine("|ARM         |" + this.Armor + "(" + Convert.ToInt16(this.PercentageArmor) + " %)");
            Console.WriteLine("|Luck        |" + this.Luck);
            Console.WriteLine("|Experience  |" + this.Experience + "/ " + this.MaxExperience);
            return null;
        }
        public Player Heal()
        {
            this.Health += Convert.ToInt32(this.MaxHealth * this.HealPercentage);
            Console.WriteLine(this.Name + " healed for " + Convert.ToInt32(this.HealPercentage * 100) + " % (" + Convert.ToInt32(this.MaxHealth * this.HealPercentage) + ") of their Max. Health!");
            Console.WriteLine();
            if(this.Health > this.MaxHealth)
            {
                this.Health = this.MaxHealth;
            }
            return null;
        }
        public Player Reset()
        {
            this.Level = 1;
            this.Experience = 0;
            this.MaxExperience = 30;
            this.MaxHealth = 100;
            this.Health = 100;
            this.AttackDamage = 40;
            this.CritChance = 10;
            this.Armor = 5;         
            this.PercentageArmor = 0;       
            this.EnemiesKilled = 0;         
            this.Skillpoints = 0;           
            this.HealPercentage = 0.1;      // = 10%
            this.Luck = 10;                 // = 10%
            this.IsDead = false;
            return null;
        }
    }
}
