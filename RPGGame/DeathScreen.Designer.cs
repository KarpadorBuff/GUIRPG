namespace RPGGame
{
    partial class Screen_Death
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Retry = new System.Windows.Forms.Button();
            this.Btn_Ragequit = new System.Windows.Forms.Button();
            this.Panel_StatBackground = new System.Windows.Forms.Panel();
            this.Label_Stats = new System.Windows.Forms.Label();
            this.Panel_StatBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "You died ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Retry
            // 
            this.Btn_Retry.FlatAppearance.BorderSize = 0;
            this.Btn_Retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retry.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Retry.Location = new System.Drawing.Point(12, 117);
            this.Btn_Retry.Name = "Btn_Retry";
            this.Btn_Retry.Size = new System.Drawing.Size(200, 100);
            this.Btn_Retry.TabIndex = 1;
            this.Btn_Retry.Text = "Retry\r\nリトライ\r\n\r\n";
            this.Btn_Retry.UseVisualStyleBackColor = true;
            this.Btn_Retry.Click += new System.EventHandler(this.Btn_Retry_Click);
            // 
            // Btn_Ragequit
            // 
            this.Btn_Ragequit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Ragequit.CausesValidation = false;
            this.Btn_Ragequit.FlatAppearance.BorderSize = 0;
            this.Btn_Ragequit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ragequit.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Ragequit.Location = new System.Drawing.Point(12, 223);
            this.Btn_Ragequit.Name = "Btn_Ragequit";
            this.Btn_Ragequit.Size = new System.Drawing.Size(200, 100);
            this.Btn_Ragequit.TabIndex = 2;
            this.Btn_Ragequit.Text = "Ragequit\r\nレジクイット";
            this.Btn_Ragequit.UseVisualStyleBackColor = true;
            this.Btn_Ragequit.Click += new System.EventHandler(this.Btn_Ragequit_Click);
            // 
            // Panel_StatBackground
            // 
            this.Panel_StatBackground.Controls.Add(this.Label_Stats);
            this.Panel_StatBackground.Location = new System.Drawing.Point(218, 117);
            this.Panel_StatBackground.Name = "Panel_StatBackground";
            this.Panel_StatBackground.Size = new System.Drawing.Size(362, 237);
            this.Panel_StatBackground.TabIndex = 3;
            // 
            // Label_Stats
            // 
            this.Label_Stats.AutoSize = true;
            this.Label_Stats.Location = new System.Drawing.Point(5, 6);
            this.Label_Stats.Name = "Label_Stats";
            this.Label_Stats.Size = new System.Drawing.Size(80, 14);
            this.Label_Stats.TabIndex = 0;
            this.Label_Stats.Text = "Your Stats:\r\n";
            // 
            // Screen_Death
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_StatBackground);
            this.Controls.Add(this.Btn_Ragequit);
            this.Controls.Add(this.Btn_Retry);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Screen_Death";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeathScreen_FormClosed);
            this.Panel_StatBackground.ResumeLayout(false);
            this.Panel_StatBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Btn_Retry;
        private Button Btn_Ragequit;
        private Panel Panel_StatBackground;
        private Label Label_Stats;
    }
}