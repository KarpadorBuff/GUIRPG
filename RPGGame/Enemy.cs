using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RPGGame;

namespace PlainTextRPG
{
    public class Enemy
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public double PlayerCritDamage { get; set; }
        public int Armor { get; set; }
        public int Level { get; set; }
        public int Deaths { get; set; }
        public int LevelUpChance { get; set; }

        public bool IsDead;

        public Enemy()
        {
            PlayerCritDamage = 1.2;
            Level = 1;
            MaxHealth = 100;
            Health = 100;
            Armor = 20;
            AttackDamage = 10;
        }

        /// <summary>
        /// Recalculates Stats for the Enemy
        /// </summary>
        /// <returns></returns>
        public Enemy CalculateStats()
        {
            this.MaxHealth += this.Level^2* 10;
            this.Armor = this.Level^2;
            this.AttackDamage = Convert.ToInt32(this.Level * 11);
            return null;
        }
        /// <summary>
        /// Enemy takes "Damage" - Enemyarmor
        /// </summary>
        /// <param name="IncomingDamage"></param>
        /// <returns></returns>
        public Enemy TakeDamage(int IncomingDamage)

        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You Attacked with " + IncomingDamage + " Damage");
            Console.WriteLine();
            
            Console.WriteLine("The Enemy has taken " + Convert.ToInt16(IncomingDamage - (IncomingDamage * 0.01 * this.Armor)) + " Damage");
            Console.WriteLine();
            this.Health -= Convert.ToInt16(IncomingDamage - (IncomingDamage * 0.01 * this.Armor));
            

            if (this.Health <= 0)
            {
                this.IsDead = true;
                this.Health = 0;
            }
            if (this.IsDead)
            {

                this.Deaths++;
                Console.WriteLine();
                Console.WriteLine("\n You killed the Enemy!\n\n");
                
            }
            return null;

        }

        public Enemy TakeCrit(int IncomingDamage)
        {
            Console.WriteLine("A Critical Attack !");
            Console.WriteLine();
            
            Console.WriteLine("The Enemy has taken " + Convert.ToInt32(IncomingDamage * this.PlayerCritDamage) + " Damage!");
            Console.WriteLine();
            
            this.Health -= Convert.ToInt32(IncomingDamage * 1.2);
            if (this.Health <= 0)
            {
                this.IsDead = true;
            }
            if (this.IsDead)
            {
                this.Deaths++;
                
                Console.WriteLine("\nYou killed the Enemy!\n");
                


            }
            
            return null;
        }

        /// <summary>
        /// Prints Status of the current Enemy
        /// </summary>
        /// <returns></returns>
        public Enemy Status()
        {
            Console.WriteLine();
            Console.WriteLine("             ______________________________");
            Console.WriteLine("             |Enemy Status:");
            Console.WriteLine("|Level       | " + this.Level);
            Console.WriteLine("|HP          | " + this.Health + "/" + this.MaxHealth);
            Console.WriteLine("|ATK         | " + this.AttackDamage);
            Console.WriteLine("|ARMOR       | " + this.Armor + " %");
            Console.WriteLine();
            Console.WriteLine();
            return null;
        }
        public Enemy Revive(int Luck)
        {

            if (this.IsDead)
            {
                Thread.Sleep(1000);
                Random LevelRandom = new Random();
                int hanswurst = LevelRandom.Next(0, 1000);
                this.LevelUpChance = hanswurst;

                if (this.LevelUpChance >= 400 + Luck)
                {
                    this.Level++;
                    this.CalculateStats();
                }
                this.IsDead = false;
                this.Health = this.MaxHealth;
                
            }
            
            
            return null;
        }
        public Enemy Reset()
        {
            this.PlayerCritDamage = 1.2;
            this.Level = 1;
            this.MaxHealth = 100;
            this.Health = 100;
            this.Armor = 20;
            this.AttackDamage = 10;
            return null;
        }
    }
}
