using Quest.Enemies;
using Quest.Potions;

namespace Quest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private int GameTime = 120;
        private Rectangle boundaries = new Rectangle(78, 57, 420, 155);

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            progress_time.Minimum = 0;
            progress_time.Maximum = GameTime;
            progress_time.Value = GameTime;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            GameTime -= 1;

            if (progress_time.Value > 0)
                progress_time.Value = GameTime;

            if (GameTime <= 0)
            {
                timer.Stop();
                var result = MessageBox.Show("Time's up! Do you want to restart the game?",
                                             "Time Over",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ReStartGame();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            this.Text = game.Level.ToString();
            UpdateCharacters();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) MoveAndUpdate(Direction.Up);
            if (e.KeyCode == Keys.A) MoveAndUpdate(Direction.Left);
            if (e.KeyCode == Keys.S) MoveAndUpdate(Direction.Down);
            if (e.KeyCode == Keys.D) MoveAndUpdate(Direction.Right);
        }
        private void MoveAndUpdate(Direction direction)
        {
            game.Move(direction, random);
            UpdateCharacters();
        }

        private void move_up_Click(object sender, EventArgs e) => MoveAndUpdate(Direction.Up);
        private void move_left_Click(object sender, EventArgs e) => MoveAndUpdate(Direction.Left);
        private void move_right_Click(object sender, EventArgs e) => MoveAndUpdate(Direction.Right);
        private void move_down_Click(object sender, EventArgs e) => MoveAndUpdate(Direction.Down);


        private void attack_up_Click(object sender, EventArgs e)
        {
            if (!HaveWeaponEquiped()) return;
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attack_left_Click(object sender, EventArgs e)
        {
            if (!HaveWeaponEquiped()) return;
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attack_right_Click(object sender, EventArgs e)
        {
            if (!HaveWeaponEquiped()) return;
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attack_down_Click(object sender, EventArgs e)
        {
            if (!HaveWeaponEquiped()) return;
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private bool HaveWeaponEquiped()
        {
            if (!game.IsHaveEquipedWeapon())
            {
                MessageBox.Show("You need to equip a weapon before attacking!");
                return false;
            }
            return true;
        }


        private void UpdateCharacters()
        {
            player_picture.Visible = true;
            player_picture.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            UpdateEnemies();
            UpdateWeaponsInRoom();
            UpdatePlayerWeapons();

            if (game.PlayerHitPoints <= 0)
            {
                var result = MessageBox.Show("You have died! Game Over.\nDo you want to restart?",
                                              "Game Over",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ReStartGame();  
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }

        private void UpdateEnemies()
        {
            int enemiesShown = 0;
            bat_picture.Visible = false;
            ghost_picture.Visible = false;
            ghoul_picture.Visible = false;
            batHitPoints.Text = "batHitPoints";
            ghostHitPoints.Text = "ghostHitPoints";
            ghoulHitPoints.Text = "ghoulHitPoints";

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat && !enemy.Dead)
                {
                    bat_picture.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    bat_picture.Visible = true;
                    enemiesShown++;
                }

                if (enemy is Ghost && !enemy.Dead)
                {
                    ghost_picture.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    ghost_picture.Visible = true;
                    enemiesShown++;
                }

                if (enemy is Ghoul && !enemy.Dead)
                {
                    ghoul_picture.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    ghoul_picture.Visible = true;
                    enemiesShown++;
                }
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated all the enemies in this level!");
                game.PlayerLocation = new Point(boundaries.Right - 20, (boundaries.Top + boundaries.Bottom) / 2 + 9);
                game.NewLevel(random);
                GameTime = 120;
                this.Text = game.Level.ToString();
                UpdateCharacters();
            }
        }

        private void UpdateWeaponsInRoom()
        {
            sword_picture.Visible = false;
            bow_picture.Visible = false;
            mace_picture.Visible = false;
            bluePotion_picture.Visible = false;
            redPotion_picture.Visible = false;

            foreach (Weapon weapon in game.WeaponInRoom)
            {
                switch (weapon.Name)
                {
                    case "Sword":
                        sword_picture.Visible = true;
                        sword_picture.Location = weapon.Location;
                        break;
                    case "Bow":
                        bow_picture.Visible = true;
                        bow_picture.Location = weapon.Location;
                        break;
                    case "Mace":
                        mace_picture.Visible = true;
                        mace_picture.Location = weapon.Location;
                        break;
                    case "BluePotion":
                        bluePotion_picture.Visible = true;
                        bluePotion_picture.Location = weapon.Location;
                        break;
                    case "RedPotion":
                        redPotion_picture.Visible = true;
                        redPotion_picture.Location = weapon.Location;
                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdatePlayerWeapons()
        {
            sword_equiped.Visible = false;
            bow_equiped.Visible = false;
            mace_equiped.Visible = false;
            bluePotion_equiped.Visible = false;
            redPotion_equiped.Visible = false;

            foreach (Weapon weapon in game.PlayerWeapons)
            {
                switch (weapon.Name)
                {
                    case "Sword":
                        sword_equiped.Visible = true;
                        break;
                    case "Bow":
                        bow_equiped.Visible = true;
                        break;
                    case "Mace":
                        mace_equiped.Visible = true;
                        break;
                    case "BluePotion":
                        if (weapon is IPotion bluePotion && !bluePotion.Used)
                        {
                            bluePotion_equiped.Visible = true;
                            break;
                        }
                        bluePotion_equiped.Enabled = false;
                        break;
                    case "RedPotion":
                        if (weapon is IPotion redPotion && !redPotion.Used)
                        {
                            redPotion_equiped.Visible = true;
                            break;
                        }
                        redPotion_equiped.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void sword_equiped_Click(object sender, EventArgs e)
        {
            clear_picked_weapons();
            sword_equiped.BorderStyle = BorderStyle.FixedSingle;
            game.Equip("Sword");
        }

        private void bow_equiped_Click(object sender, EventArgs e)
        {
            clear_picked_weapons();
            bow_equiped.BorderStyle = BorderStyle.FixedSingle;
            game.Equip("Bow");
        }

        private void mace_equiped_Click(object sender, EventArgs e)
        {
            clear_picked_weapons();
            mace_equiped.BorderStyle = BorderStyle.FixedSingle;
            game.Equip("Mace");
        }

        private void bluePotion_equiped_Click(object sender, EventArgs e)
        {
            clear_picked_weapons();
            bluePotion_equiped.BorderStyle = BorderStyle.FixedSingle;
            game.Equip("BluePotion");
        }

        private void redPotion_equiped_Click(object sender, EventArgs e)
        {
            clear_picked_weapons();
            redPotion_equiped.BorderStyle = BorderStyle.FixedSingle;
            game.Equip("RedPotion");
        }

        private void clear_picked_weapons()
        {
            sword_equiped.BorderStyle = BorderStyle.None;
            bow_equiped.BorderStyle = BorderStyle.None;
            mace_equiped.BorderStyle = BorderStyle.None;
            bluePotion_equiped.BorderStyle = BorderStyle.None;
            redPotion_equiped.BorderStyle = BorderStyle.None;
        }

        private void ReStartGame()
        {
            timer.Stop();
            GameTime = 120;
            clear_picked_weapons();
            progress_time.Value = GameTime;
            game.ReStartGame();
            game.PlayerWeapons.Clear();
            game.PlayerHitPoints = 10;
            this.Text = game.Level.ToString();
            UpdateCharacters();
            timer.Start();
        }
    }
}
