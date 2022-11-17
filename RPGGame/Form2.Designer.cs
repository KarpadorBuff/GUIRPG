namespace RPGGame
{
    partial class Screen_LevelUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_Done = new System.Windows.Forms.Button();
            this.Btn_Remove_Crit = new System.Windows.Forms.Button();
            this.Btn_Remove_Armor = new System.Windows.Forms.Button();
            this.Btn_Remove_Healing = new System.Windows.Forms.Button();
            this.Btn_Remove_Health = new System.Windows.Forms.Button();
            this.Btn_Remove_AttackDamage = new System.Windows.Forms.Button();
            this.Btn_Remove_Luck = new System.Windows.Forms.Button();
            this.Label_AttackDamage = new System.Windows.Forms.Label();
            this.Label_Luck = new System.Windows.Forms.Label();
            this.Label_Armor = new System.Windows.Forms.Label();
            this.Label_Healing = new System.Windows.Forms.Label();
            this.Label_Health = new System.Windows.Forms.Label();
            this.Label_Crit = new System.Windows.Forms.Label();
            this.Btn_Add_Crit = new System.Windows.Forms.Button();
            this.Btn_Add_Armor = new System.Windows.Forms.Button();
            this.Btn_Add_Healing = new System.Windows.Forms.Button();
            this.Btn_Add_Health = new System.Windows.Forms.Button();
            this.Btn_Add_AttackDamage = new System.Windows.Forms.Button();
            this.Btn_Add_Luck = new System.Windows.Forms.Button();
            this.Btn_ApplySkillpoints = new System.Windows.Forms.Button();
            this.Label_AddedValue_AttackDamage = new System.Windows.Forms.Label();
            this.Label_AddedValue_Health = new System.Windows.Forms.Label();
            this.Label_AddedValue_Healing = new System.Windows.Forms.Label();
            this.Label_AddedValue_Luck = new System.Windows.Forms.Label();
            this.Label_AddedValue_Crit = new System.Windows.Forms.Label();
            this.Label_AddedValue_Armor = new System.Windows.Forms.Label();
            this.Label_Skillpoint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Btn_Done
            // 
            this.Btn_Done.Enabled = false;
            this.Btn_Done.Location = new System.Drawing.Point(12, 386);
            this.Btn_Done.Name = "Btn_Done";
            this.Btn_Done.Size = new System.Drawing.Size(304, 52);
            this.Btn_Done.TabIndex = 0;
            this.Btn_Done.Text = "Done";
            this.Btn_Done.UseVisualStyleBackColor = true;
            this.Btn_Done.Click += new System.EventHandler(this.Btn_Done_Click);
            // 
            // Btn_Remove_Crit
            // 
            this.Btn_Remove_Crit.Location = new System.Drawing.Point(50, 305);
            this.Btn_Remove_Crit.Name = "Btn_Remove_Crit";
            this.Btn_Remove_Crit.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove_Crit.TabIndex = 19;
            this.Btn_Remove_Crit.Text = "-";
            this.Btn_Remove_Crit.UseVisualStyleBackColor = true;
            this.Btn_Remove_Crit.Click += new System.EventHandler(this.Btn_Remove_Crit_Click);
            // 
            // Btn_Remove_Armor
            // 
            this.Btn_Remove_Armor.Location = new System.Drawing.Point(50, 269);
            this.Btn_Remove_Armor.Name = "Btn_Remove_Armor";
            this.Btn_Remove_Armor.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove_Armor.TabIndex = 18;
            this.Btn_Remove_Armor.Text = "-";
            this.Btn_Remove_Armor.UseVisualStyleBackColor = true;
            this.Btn_Remove_Armor.Click += new System.EventHandler(this.Btn_Remove_Armor_Click);
            // 
            // Btn_Remove_Healing
            // 
            this.Btn_Remove_Healing.Location = new System.Drawing.Point(50, 233);
            this.Btn_Remove_Healing.Name = "Btn_Remove_Healing";
            this.Btn_Remove_Healing.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove_Healing.TabIndex = 17;
            this.Btn_Remove_Healing.Text = "-";
            this.Btn_Remove_Healing.UseVisualStyleBackColor = true;
            this.Btn_Remove_Healing.Click += new System.EventHandler(this.Btn_Remove_Healing_Click);
            // 
            // Btn_Remove_Health
            // 
            this.Btn_Remove_Health.Location = new System.Drawing.Point(50, 197);
            this.Btn_Remove_Health.Name = "Btn_Remove_Health";
            this.Btn_Remove_Health.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove_Health.TabIndex = 16;
            this.Btn_Remove_Health.Text = "-";
            this.Btn_Remove_Health.UseVisualStyleBackColor = true;
            this.Btn_Remove_Health.Click += new System.EventHandler(this.Btn_Remove_Health_Click);
            // 
            // Btn_Remove_AttackDamage
            // 
            this.Btn_Remove_AttackDamage.Location = new System.Drawing.Point(50, 161);
            this.Btn_Remove_AttackDamage.Name = "Btn_Remove_AttackDamage";
            this.Btn_Remove_AttackDamage.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove_AttackDamage.TabIndex = 15;
            this.Btn_Remove_AttackDamage.Text = "-";
            this.Btn_Remove_AttackDamage.UseVisualStyleBackColor = true;
            this.Btn_Remove_AttackDamage.Click += new System.EventHandler(this.Btn_Remove_AttackDamage_Click);
            // 
            // Btn_Remove_Luck
            // 
            this.Btn_Remove_Luck.Location = new System.Drawing.Point(50, 341);
            this.Btn_Remove_Luck.Name = "Btn_Remove_Luck";
            this.Btn_Remove_Luck.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove_Luck.TabIndex = 14;
            this.Btn_Remove_Luck.Text = "-";
            this.Btn_Remove_Luck.UseVisualStyleBackColor = true;
            this.Btn_Remove_Luck.Click += new System.EventHandler(this.Btn_Remove_Luck_Click);
            // 
            // Label_AttackDamage
            // 
            this.Label_AttackDamage.AutoSize = true;
            this.Label_AttackDamage.Location = new System.Drawing.Point(208, 169);
            this.Label_AttackDamage.Name = "Label_AttackDamage";
            this.Label_AttackDamage.Size = new System.Drawing.Size(88, 15);
            this.Label_AttackDamage.TabIndex = 20;
            this.Label_AttackDamage.Text = "Attack Damage";
            this.Label_AttackDamage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Luck
            // 
            this.Label_Luck.AutoSize = true;
            this.Label_Luck.Location = new System.Drawing.Point(208, 349);
            this.Label_Luck.Name = "Label_Luck";
            this.Label_Luck.Size = new System.Drawing.Size(32, 15);
            this.Label_Luck.TabIndex = 21;
            this.Label_Luck.Text = "Luck";
            this.Label_Luck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Armor
            // 
            this.Label_Armor.AutoSize = true;
            this.Label_Armor.Location = new System.Drawing.Point(208, 277);
            this.Label_Armor.Name = "Label_Armor";
            this.Label_Armor.Size = new System.Drawing.Size(41, 15);
            this.Label_Armor.TabIndex = 22;
            this.Label_Armor.Text = "Armor";
            this.Label_Armor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Healing
            // 
            this.Label_Healing.AutoSize = true;
            this.Label_Healing.Location = new System.Drawing.Point(208, 241);
            this.Label_Healing.Name = "Label_Healing";
            this.Label_Healing.Size = new System.Drawing.Size(48, 15);
            this.Label_Healing.TabIndex = 23;
            this.Label_Healing.Text = "Healing";
            this.Label_Healing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Health
            // 
            this.Label_Health.AutoSize = true;
            this.Label_Health.Location = new System.Drawing.Point(208, 205);
            this.Label_Health.Name = "Label_Health";
            this.Label_Health.Size = new System.Drawing.Size(42, 15);
            this.Label_Health.TabIndex = 24;
            this.Label_Health.Text = "Health";
            this.Label_Health.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Crit
            // 
            this.Label_Crit.AutoSize = true;
            this.Label_Crit.Location = new System.Drawing.Point(208, 313);
            this.Label_Crit.Name = "Label_Crit";
            this.Label_Crit.Size = new System.Drawing.Size(26, 15);
            this.Label_Crit.TabIndex = 25;
            this.Label_Crit.Text = "Crit";
            this.Label_Crit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Add_Crit
            // 
            this.Btn_Add_Crit.Location = new System.Drawing.Point(14, 305);
            this.Btn_Add_Crit.Name = "Btn_Add_Crit";
            this.Btn_Add_Crit.Size = new System.Drawing.Size(30, 30);
            this.Btn_Add_Crit.TabIndex = 31;
            this.Btn_Add_Crit.Text = "+";
            this.Btn_Add_Crit.UseVisualStyleBackColor = true;
            this.Btn_Add_Crit.Click += new System.EventHandler(this.Btn_Add_Crit_Click);
            // 
            // Btn_Add_Armor
            // 
            this.Btn_Add_Armor.Location = new System.Drawing.Point(14, 269);
            this.Btn_Add_Armor.Name = "Btn_Add_Armor";
            this.Btn_Add_Armor.Size = new System.Drawing.Size(30, 30);
            this.Btn_Add_Armor.TabIndex = 30;
            this.Btn_Add_Armor.Text = "+";
            this.Btn_Add_Armor.UseVisualStyleBackColor = true;
            this.Btn_Add_Armor.Click += new System.EventHandler(this.Btn_Add_Armor_Click);
            // 
            // Btn_Add_Healing
            // 
            this.Btn_Add_Healing.Location = new System.Drawing.Point(14, 233);
            this.Btn_Add_Healing.Name = "Btn_Add_Healing";
            this.Btn_Add_Healing.Size = new System.Drawing.Size(30, 30);
            this.Btn_Add_Healing.TabIndex = 29;
            this.Btn_Add_Healing.Text = "+";
            this.Btn_Add_Healing.UseVisualStyleBackColor = true;
            this.Btn_Add_Healing.Click += new System.EventHandler(this.Btn_Add_Healing_Click);
            // 
            // Btn_Add_Health
            // 
            this.Btn_Add_Health.Location = new System.Drawing.Point(14, 197);
            this.Btn_Add_Health.Name = "Btn_Add_Health";
            this.Btn_Add_Health.Size = new System.Drawing.Size(30, 30);
            this.Btn_Add_Health.TabIndex = 28;
            this.Btn_Add_Health.Text = "+";
            this.Btn_Add_Health.UseVisualStyleBackColor = true;
            this.Btn_Add_Health.Click += new System.EventHandler(this.Btn_Add_Health_Click);
            // 
            // Btn_Add_AttackDamage
            // 
            this.Btn_Add_AttackDamage.Location = new System.Drawing.Point(14, 161);
            this.Btn_Add_AttackDamage.Name = "Btn_Add_AttackDamage";
            this.Btn_Add_AttackDamage.Size = new System.Drawing.Size(30, 30);
            this.Btn_Add_AttackDamage.TabIndex = 27;
            this.Btn_Add_AttackDamage.Text = "+";
            this.Btn_Add_AttackDamage.UseVisualStyleBackColor = true;
            this.Btn_Add_AttackDamage.Click += new System.EventHandler(this.Btn_Add_AttackDamage_Click);
            // 
            // Btn_Add_Luck
            // 
            this.Btn_Add_Luck.Location = new System.Drawing.Point(14, 341);
            this.Btn_Add_Luck.Name = "Btn_Add_Luck";
            this.Btn_Add_Luck.Size = new System.Drawing.Size(30, 30);
            this.Btn_Add_Luck.TabIndex = 26;
            this.Btn_Add_Luck.Text = "+";
            this.Btn_Add_Luck.UseVisualStyleBackColor = true;
            this.Btn_Add_Luck.Click += new System.EventHandler(this.Btn_Add_Luck_Click);
            // 
            // Btn_ApplySkillpoints
            // 
            this.Btn_ApplySkillpoints.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ApplySkillpoints.Location = new System.Drawing.Point(127, 153);
            this.Btn_ApplySkillpoints.Name = "Btn_ApplySkillpoints";
            this.Btn_ApplySkillpoints.Size = new System.Drawing.Size(75, 229);
            this.Btn_ApplySkillpoints.TabIndex = 44;
            this.Btn_ApplySkillpoints.Text = "→\r\n→\r\n→\r\n→\r\n→\r\n→\r\n→\r\n→\r\n";
            this.Btn_ApplySkillpoints.UseVisualStyleBackColor = true;
            this.Btn_ApplySkillpoints.Click += new System.EventHandler(this.Btn_ApplySkillpoints_Click);
            // 
            // Label_AddedValue_AttackDamage
            // 
            this.Label_AddedValue_AttackDamage.AutoSize = true;
            this.Label_AddedValue_AttackDamage.Location = new System.Drawing.Point(86, 169);
            this.Label_AddedValue_AttackDamage.Name = "Label_AddedValue_AttackDamage";
            this.Label_AddedValue_AttackDamage.Size = new System.Drawing.Size(13, 15);
            this.Label_AddedValue_AttackDamage.TabIndex = 45;
            this.Label_AddedValue_AttackDamage.Text = "0";
            // 
            // Label_AddedValue_Health
            // 
            this.Label_AddedValue_Health.AutoSize = true;
            this.Label_AddedValue_Health.Location = new System.Drawing.Point(86, 205);
            this.Label_AddedValue_Health.Name = "Label_AddedValue_Health";
            this.Label_AddedValue_Health.Size = new System.Drawing.Size(13, 15);
            this.Label_AddedValue_Health.TabIndex = 46;
            this.Label_AddedValue_Health.Text = "0";
            // 
            // Label_AddedValue_Healing
            // 
            this.Label_AddedValue_Healing.AutoSize = true;
            this.Label_AddedValue_Healing.Location = new System.Drawing.Point(86, 241);
            this.Label_AddedValue_Healing.Name = "Label_AddedValue_Healing";
            this.Label_AddedValue_Healing.Size = new System.Drawing.Size(26, 15);
            this.Label_AddedValue_Healing.TabIndex = 47;
            this.Label_AddedValue_Healing.Text = "0 %";
            // 
            // Label_AddedValue_Luck
            // 
            this.Label_AddedValue_Luck.AutoSize = true;
            this.Label_AddedValue_Luck.Location = new System.Drawing.Point(86, 349);
            this.Label_AddedValue_Luck.Name = "Label_AddedValue_Luck";
            this.Label_AddedValue_Luck.Size = new System.Drawing.Size(13, 15);
            this.Label_AddedValue_Luck.TabIndex = 50;
            this.Label_AddedValue_Luck.Text = "0";
            // 
            // Label_AddedValue_Crit
            // 
            this.Label_AddedValue_Crit.AutoSize = true;
            this.Label_AddedValue_Crit.Location = new System.Drawing.Point(86, 313);
            this.Label_AddedValue_Crit.Name = "Label_AddedValue_Crit";
            this.Label_AddedValue_Crit.Size = new System.Drawing.Size(13, 15);
            this.Label_AddedValue_Crit.TabIndex = 49;
            this.Label_AddedValue_Crit.Text = "0";
            // 
            // Label_AddedValue_Armor
            // 
            this.Label_AddedValue_Armor.AutoSize = true;
            this.Label_AddedValue_Armor.Location = new System.Drawing.Point(86, 277);
            this.Label_AddedValue_Armor.Name = "Label_AddedValue_Armor";
            this.Label_AddedValue_Armor.Size = new System.Drawing.Size(13, 15);
            this.Label_AddedValue_Armor.TabIndex = 48;
            this.Label_AddedValue_Armor.Text = "0";
            // 
            // Label_Skillpoint
            // 
            this.Label_Skillpoint.AutoSize = true;
            this.Label_Skillpoint.Location = new System.Drawing.Point(85, 95);
            this.Label_Skillpoint.Name = "Label_Skillpoint";
            this.Label_Skillpoint.Size = new System.Drawing.Size(38, 15);
            this.Label_Skillpoint.TabIndex = 51;
            this.Label_Skillpoint.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Screen_LevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.Label_Skillpoint);
            this.Controls.Add(this.Label_AddedValue_Luck);
            this.Controls.Add(this.Label_AddedValue_Crit);
            this.Controls.Add(this.Label_AddedValue_Armor);
            this.Controls.Add(this.Label_AddedValue_Healing);
            this.Controls.Add(this.Label_AddedValue_Health);
            this.Controls.Add(this.Label_AddedValue_AttackDamage);
            this.Controls.Add(this.Btn_ApplySkillpoints);
            this.Controls.Add(this.Btn_Add_Crit);
            this.Controls.Add(this.Btn_Add_Armor);
            this.Controls.Add(this.Btn_Add_Healing);
            this.Controls.Add(this.Btn_Add_Health);
            this.Controls.Add(this.Btn_Add_AttackDamage);
            this.Controls.Add(this.Btn_Add_Luck);
            this.Controls.Add(this.Label_Crit);
            this.Controls.Add(this.Label_Health);
            this.Controls.Add(this.Label_Healing);
            this.Controls.Add(this.Label_Armor);
            this.Controls.Add(this.Label_Luck);
            this.Controls.Add(this.Label_AttackDamage);
            this.Controls.Add(this.Btn_Remove_Crit);
            this.Controls.Add(this.Btn_Remove_Armor);
            this.Controls.Add(this.Btn_Remove_Healing);
            this.Controls.Add(this.Btn_Remove_Health);
            this.Controls.Add(this.Btn_Remove_AttackDamage);
            this.Controls.Add(this.Btn_Remove_Luck);
            this.Controls.Add(this.Btn_Done);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Screen_LevelUp";
            this.Load += new System.EventHandler(this.Screen_LevelUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Done;
        private Button Btn_Remove_Crit;
        private Button Btn_Remove_Armor;
        private Button Btn_Remove_Healing;
        private Button Btn_Remove_Health;
        private Button Btn_Remove_AttackDamage;
        private Button Btn_Remove_Luck;
        private Label Label_AttackDamage;
        private Label Label_Luck;
        private Label Label_Armor;
        private Label Label_Healing;
        private Label Label_Health;
        private Label Label_Crit;
        private Button Btn_Add_Crit;
        private Button Btn_Add_Armor;
        private Button Btn_Add_Healing;
        private Button Btn_Add_Health;
        private Button Btn_Add_AttackDamage;
        private Button Btn_Add_Luck;
        private Button Btn_ApplySkillpoints;
        private Label Label_AddedValue_AttackDamage;
        private Label Label_AddedValue_Health;
        private Label Label_AddedValue_Healing;
        private Label Label_AddedValue_Luck;
        private Label Label_AddedValue_Crit;
        private Label Label_AddedValue_Armor;
        private Label Label_Skillpoint;
        private System.Windows.Forms.Timer timer1;
    }
}