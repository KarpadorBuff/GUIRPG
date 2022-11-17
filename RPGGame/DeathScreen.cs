using PlainTextRPG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGame
{
    public partial class Screen_Death : Form
    {
        public static Screen_Death instance;
        public static Boolean deathscreenIsShowing;
        public Screen_Death()
        {
            InitializeComponent();
            instance = this;
            deathscreenIsShowing = Screen_Gameplay.instance.deathscreenIsShowing;

        }

        private void Btn_Retry_Click(object sender, EventArgs e)
        {
            Screen_Death.ActiveForm.Close();
        }

        private void Btn_Ragequit_Click(object sender, EventArgs e)
        {
            Screen_Death.ActiveForm.Close();
            Screen_Gameplay.instance.Close();
        }

        private void DeathScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Screen_Gameplay.instance.deathscreenIsShowing = false;
        }
    }
}
