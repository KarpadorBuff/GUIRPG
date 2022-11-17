namespace RPGGame
{
    partial class Screen_Gameplay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_Attack = new System.Windows.Forms.Button();
            this.Btn_Heal = new System.Windows.Forms.Button();
            this.player_Textbox_HP = new System.Windows.Forms.TextBox();
            this.LabelUpdates = new System.Windows.Forms.Timer(this.components);
            this.player_label_HP = new System.Windows.Forms.Label();
            this.enemy_TextBox_HP = new System.Windows.Forms.TextBox();
            this.enemy_label_HP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelEXP = new System.Windows.Forms.Label();
            this.Label_enemyLevel = new System.Windows.Forms.Label();
            this.enemy_statwindow = new System.Windows.Forms.Panel();
            this.enemy_statwindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Attack
            // 
            this.Btn_Attack.FlatAppearance.BorderSize = 0;
            this.Btn_Attack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Attack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Attack.Location = new System.Drawing.Point(0, 362);
            this.Btn_Attack.Name = "Btn_Attack";
            this.Btn_Attack.Size = new System.Drawing.Size(150, 100);
            this.Btn_Attack.TabIndex = 0;
            this.Btn_Attack.TabStop = false;
            this.Btn_Attack.Text = "Attack";
            this.Btn_Attack.UseVisualStyleBackColor = true;
            this.Btn_Attack.Click += new System.EventHandler(this.Btn_Attack_Click);
            // 
            // Btn_Heal
            // 
            this.Btn_Heal.FlatAppearance.BorderSize = 0;
            this.Btn_Heal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Heal.Location = new System.Drawing.Point(156, 362);
            this.Btn_Heal.Name = "Btn_Heal";
            this.Btn_Heal.Size = new System.Drawing.Size(150, 100);
            this.Btn_Heal.TabIndex = 1;
            this.Btn_Heal.TabStop = false;
            this.Btn_Heal.Text = "Heal";
            this.Btn_Heal.UseVisualStyleBackColor = true;
            this.Btn_Heal.Click += new System.EventHandler(this.Btn_Heal_Click);
            // 
            // player_Textbox_HP
            // 
            this.player_Textbox_HP.BackColor = System.Drawing.Color.DarkGray;
            this.player_Textbox_HP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player_Textbox_HP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player_Textbox_HP.ForeColor = System.Drawing.Color.Lime;
            this.player_Textbox_HP.Location = new System.Drawing.Point(0, 342);
            this.player_Textbox_HP.Multiline = true;
            this.player_Textbox_HP.Name = "player_Textbox_HP";
            this.player_Textbox_HP.ReadOnly = true;
            this.player_Textbox_HP.Size = new System.Drawing.Size(456, 15);
            this.player_Textbox_HP.TabIndex = 2;
            this.player_Textbox_HP.TabStop = false;
            this.player_Textbox_HP.Text = "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\r\n\r\n\r\n\r\n";
            // 
            // LabelUpdates
            // 
            this.LabelUpdates.Enabled = true;
            this.LabelUpdates.Interval = 50;
            this.LabelUpdates.Tick += new System.EventHandler(this.LabelUpdates_Tick);
            // 
            // player_label_HP
            // 
            this.player_label_HP.AutoSize = true;
            this.player_label_HP.BackColor = System.Drawing.Color.Transparent;
            this.player_label_HP.Location = new System.Drawing.Point(12, 316);
            this.player_label_HP.Name = "player_label_HP";
            this.player_label_HP.Size = new System.Drawing.Size(55, 15);
            this.player_label_HP.TabIndex = 3;
            this.player_label_HP.Text = "PlayerHP";
            // 
            // enemy_TextBox_HP
            // 
            this.enemy_TextBox_HP.BackColor = System.Drawing.Color.DarkGray;
            this.enemy_TextBox_HP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enemy_TextBox_HP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enemy_TextBox_HP.ForeColor = System.Drawing.Color.Lime;
            this.enemy_TextBox_HP.Location = new System.Drawing.Point(178, 0);
            this.enemy_TextBox_HP.Multiline = true;
            this.enemy_TextBox_HP.Name = "enemy_TextBox_HP";
            this.enemy_TextBox_HP.ReadOnly = true;
            this.enemy_TextBox_HP.Size = new System.Drawing.Size(456, 15);
            this.enemy_TextBox_HP.TabIndex = 4;
            this.enemy_TextBox_HP.TabStop = false;
            this.enemy_TextBox_HP.Text = "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\r\n\r\n\r\n\r\n\r\n";
            this.enemy_TextBox_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enemy_label_HP
            // 
            this.enemy_label_HP.AutoSize = true;
            this.enemy_label_HP.Location = new System.Drawing.Point(3, 17);
            this.enemy_label_HP.Name = "enemy_label_HP";
            this.enemy_label_HP.Size = new System.Drawing.Size(59, 15);
            this.enemy_label_HP.TabIndex = 5;
            this.enemy_label_HP.Text = "enemyHP";
            this.enemy_label_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Minecraftia", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(312, 363);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 99);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Bruh\r\nBruh\r\nBruh\r\n";
            // 
            // LabelEXP
            // 
            this.LabelEXP.AutoSize = true;
            this.LabelEXP.Location = new System.Drawing.Point(12, 301);
            this.LabelEXP.Name = "LabelEXP";
            this.LabelEXP.Size = new System.Drawing.Size(30, 15);
            this.LabelEXP.TabIndex = 7;
            this.LabelEXP.Text = "EXP:";
            // 
            // Label_enemyLevel
            // 
            this.Label_enemyLevel.AutoSize = true;
            this.Label_enemyLevel.Location = new System.Drawing.Point(3, 2);
            this.Label_enemyLevel.Name = "Label_enemyLevel";
            this.Label_enemyLevel.Size = new System.Drawing.Size(30, 15);
            this.Label_enemyLevel.TabIndex = 8;
            this.Label_enemyLevel.Text = "EXP:";
            // 
            // enemy_statwindow
            // 
            this.enemy_statwindow.Controls.Add(this.Label_enemyLevel);
            this.enemy_statwindow.Controls.Add(this.enemy_label_HP);
            this.enemy_statwindow.Location = new System.Drawing.Point(0, 0);
            this.enemy_statwindow.Name = "enemy_statwindow";
            this.enemy_statwindow.Size = new System.Drawing.Size(181, 100);
            this.enemy_statwindow.TabIndex = 9;
            // 
            // Screen_Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.enemy_statwindow);
            this.Controls.Add(this.LabelEXP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enemy_TextBox_HP);
            this.Controls.Add(this.player_label_HP);
            this.Controls.Add(this.player_Textbox_HP);
            this.Controls.Add(this.Btn_Heal);
            this.Controls.Add(this.Btn_Attack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Screen_Gameplay";
            this.Text = "Bruhgame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.enemy_statwindow.ResumeLayout(false);
            this.enemy_statwindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Attack;
        private Button Btn_Heal;
        private TextBox player_Textbox_HP;
        private System.Windows.Forms.Timer LabelUpdates;
        private Label player_label_HP;
        private TextBox enemy_TextBox_HP;
        private Label enemy_label_HP;
        private TextBox textBox1;
        private Label LabelEXP;
        private Label Label_enemyLevel;
        private Panel enemy_statwindow;
    }
}