using PlainTextRPG;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace RPGGame
{
    public partial class Screen_Gameplay : Form
    {
        public static Screen_Gameplay instance;
        public string deathscreendecision = "";
        public Player player = new Player();
        public Enemy enemy = new Enemy();
        public Screen_LevelUp levelupScreen = new();
        double player_HP_OneFiftyth = 0;
        double enemy_HP_OneFiftyth = 0;
        public bool deathscreenIsShowing = false;
        public bool levelupScreenOpened = false;
        public bool runthrough;

        private ColorPalette colorpalette = new ColorPalette("388FE5", "4E88BC", "597081", "36494E", "292929");

        public Screen_Gameplay()
        {
            InitializeComponent();
            instance = this;
        }
        public void OnceEverythingisDone()
        {
            if (player_HP_OneFiftyth == player_Textbox_HP.Text.Count() && enemy_HP_OneFiftyth == enemy_TextBox_HP.Text.Count())
            {
                Btn_Attack.Enabled = true;
                Btn_Heal.Enabled = true;
                runthrough = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = colorpalette.GetColor(4);
            this.Btn_Attack.BackColor = colorpalette.GetColor(3);
            this.Btn_Heal.BackColor = colorpalette.GetColor(3);
            this.player_Textbox_HP.BackColor = colorpalette.GetColor(3);
            this.player_Textbox_HP.ForeColor = colorpalette.GetColor(0);
            this.enemy_TextBox_HP.BackColor = colorpalette.GetColor(3);
            this.enemy_TextBox_HP.ForeColor = colorpalette.GetColor(0);
            this.enemy_statwindow.BackColor = colorpalette.GetColor(2);
        }

        private void Btn_Attack_Click(object sender, EventArgs e)
        {
            Btn_Attack.Enabled = false;
            Btn_Heal.Enabled = false;
            enemy.TakeDamage(player.AttackDamage);
            player.TakeDamage(enemy.AttackDamage, enemy.IsDead);
            if (enemy_TextBox_HP.Text.Count() <= 0)
            {
                enemy.Revive(player.Luck);
                player.Experience += 10 + enemy.Level*player.Luck;
            }
                
        }
        private void Btn_Heal_Click(object sender, EventArgs e)
        {
            Btn_Heal.Enabled = false;
            Btn_Attack.Enabled = false;
            player.Heal();
            player.TakeDamage(enemy.AttackDamage, enemy.IsDead);
        }
        private void LabelUpdates_Tick(object sender, EventArgs e)
        {

            if (enemy.Health <= 0 && enemy_HP_OneFiftyth == enemy_TextBox_HP.Text.Count())
            {
                Thread.Sleep(500);
                player.GainEXP(enemy.Level);
                player.AttemptLevelUp();
                enemy.Revive(player.Luck);
            }
            LabelEXP.Text = player.Experience + "/ " + player.MaxExperience;
            Label_enemyLevel.Text = "Lv.: " + enemy.Level;

            player_HP_OneFiftyth = Convert.ToInt16(player.Health / Convert.ToInt16(player.MaxHealth / 50));
            enemy_HP_OneFiftyth = Convert.ToInt16(enemy.Health / Convert.ToInt16(enemy.MaxHealth / 50));


            if (enemy_TextBox_HP.Text.Count() > enemy_HP_OneFiftyth)
            {
                if (enemy_TextBox_HP.Text.Length > 0)
                    enemy_TextBox_HP.Text = enemy_TextBox_HP.Text.Substring(0, enemy_TextBox_HP.Text.Length - 1);
            }
            else if (enemy_TextBox_HP.Text.Count() < enemy_HP_OneFiftyth)
            {
                enemy_TextBox_HP.Text += "▬";
            }
            else if (enemy_HP_OneFiftyth == enemy_TextBox_HP.Text.Count())
            {
                if (player_Textbox_HP.Text.Count() > player_HP_OneFiftyth)
                {
                    if (player_Textbox_HP.Text.Length != 0)
                        player_Textbox_HP.Text = player_Textbox_HP.Text.Substring(0, player_Textbox_HP.Text.Length - 1);
                }
                else if (player_Textbox_HP.Text.Count() < player_HP_OneFiftyth)
                {
                    player_Textbox_HP.Text += "▬";
                }
            }


            enemy_label_HP.Text = enemy.Health + "/" + enemy.MaxHealth;
            player_label_HP.Text = player.Health + "/" + player.MaxHealth;

            if (player.IsDead && !deathscreenIsShowing)
            {
                deathscreenIsShowing = true;
                Screen_Death deathScreen = new Screen_Death();
                deathScreen.ShowDialog();
                player.Reset();
                enemy.Reset();
            }


            OnceEverythingisDone();
        }

        
    }
}