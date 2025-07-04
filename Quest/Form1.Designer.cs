namespace Quest
{
    partial class Form1
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
            sword_picture = new PictureBox();
            ghoul_picture = new PictureBox();
            ghost_picture = new PictureBox();
            bat_picture = new PictureBox();
            player_picture = new PictureBox();
            redPotion_picture = new PictureBox();
            bluePotion_picture = new PictureBox();
            mace_picture = new PictureBox();
            bow_picture = new PictureBox();
            sword_equiped = new PictureBox();
            bow_equiped = new PictureBox();
            mace_equiped = new PictureBox();
            bluePotion_equiped = new PictureBox();
            redPotion_equiped = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ghoulHitPoints = new Label();
            ghostHitPoints = new Label();
            batHitPoints = new Label();
            playerHitPoints = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            move_up = new Button();
            move_left = new Button();
            move_right = new Button();
            move_down = new Button();
            attack_down = new Button();
            attack_right = new Button();
            attack_left = new Button();
            attack_up = new Button();
            ((System.ComponentModel.ISupportInitialize)sword_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghoul_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghost_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bat_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redPotion_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bluePotion_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mace_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bow_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sword_equiped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bow_equiped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mace_equiped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bluePotion_equiped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redPotion_equiped).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // sword_picture
            // 
            sword_picture.BackColor = Color.Transparent;
            sword_picture.Image = Properties.Resources.sword;
            sword_picture.Location = new Point(227, 61);
            sword_picture.Name = "sword_picture";
            sword_picture.Size = new Size(30, 30);
            sword_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            sword_picture.TabIndex = 0;
            sword_picture.TabStop = false;
            sword_picture.Visible = false;
            // 
            // ghoul_picture
            // 
            ghoul_picture.BackColor = Color.Transparent;
            ghoul_picture.Image = Properties.Resources.ghost;
            ghoul_picture.Location = new Point(191, 61);
            ghoul_picture.Name = "ghoul_picture";
            ghoul_picture.Size = new Size(30, 30);
            ghoul_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            ghoul_picture.TabIndex = 1;
            ghoul_picture.TabStop = false;
            ghoul_picture.Visible = false;
            // 
            // ghost_picture
            // 
            ghost_picture.BackColor = Color.Transparent;
            ghost_picture.Image = Properties.Resources.ghoul;
            ghost_picture.Location = new Point(155, 61);
            ghost_picture.Name = "ghost_picture";
            ghost_picture.Size = new Size(30, 30);
            ghost_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            ghost_picture.TabIndex = 2;
            ghost_picture.TabStop = false;
            ghost_picture.Visible = false;
            // 
            // bat_picture
            // 
            bat_picture.BackColor = Color.Transparent;
            bat_picture.Image = Properties.Resources.bat;
            bat_picture.Location = new Point(119, 61);
            bat_picture.Name = "bat_picture";
            bat_picture.Size = new Size(30, 30);
            bat_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            bat_picture.TabIndex = 3;
            bat_picture.TabStop = false;
            bat_picture.Visible = false;
            // 
            // player_picture
            // 
            player_picture.BackColor = Color.Transparent;
            player_picture.Image = Properties.Resources.player;
            player_picture.Location = new Point(83, 61);
            player_picture.Name = "player_picture";
            player_picture.Size = new Size(30, 30);
            player_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            player_picture.TabIndex = 4;
            player_picture.TabStop = false;
            player_picture.Visible = false;
            // 
            // redPotion_picture
            // 
            redPotion_picture.BackColor = Color.Transparent;
            redPotion_picture.Image = Properties.Resources.potion_red;
            redPotion_picture.Location = new Point(371, 61);
            redPotion_picture.Name = "redPotion_picture";
            redPotion_picture.Size = new Size(30, 30);
            redPotion_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            redPotion_picture.TabIndex = 5;
            redPotion_picture.TabStop = false;
            redPotion_picture.Visible = false;
            // 
            // bluePotion_picture
            // 
            bluePotion_picture.BackColor = Color.Transparent;
            bluePotion_picture.Image = Properties.Resources.potion_blue;
            bluePotion_picture.Location = new Point(335, 61);
            bluePotion_picture.Name = "bluePotion_picture";
            bluePotion_picture.Size = new Size(30, 30);
            bluePotion_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            bluePotion_picture.TabIndex = 6;
            bluePotion_picture.TabStop = false;
            bluePotion_picture.Visible = false;
            // 
            // mace_picture
            // 
            mace_picture.BackColor = Color.Transparent;
            mace_picture.Image = Properties.Resources.mace;
            mace_picture.Location = new Point(299, 61);
            mace_picture.Name = "mace_picture";
            mace_picture.Size = new Size(30, 30);
            mace_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            mace_picture.TabIndex = 7;
            mace_picture.TabStop = false;
            mace_picture.Visible = false;
            // 
            // bow_picture
            // 
            bow_picture.BackColor = Color.Transparent;
            bow_picture.Image = Properties.Resources.bow;
            bow_picture.Location = new Point(263, 61);
            bow_picture.Name = "bow_picture";
            bow_picture.Size = new Size(30, 30);
            bow_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            bow_picture.TabIndex = 8;
            bow_picture.TabStop = false;
            bow_picture.Visible = false;
            // 
            // sword_equiped
            // 
            sword_equiped.BackColor = Color.Transparent;
            sword_equiped.Image = Properties.Resources.sword;
            sword_equiped.Location = new Point(83, 317);
            sword_equiped.Name = "sword_equiped";
            sword_equiped.Size = new Size(50, 50);
            sword_equiped.SizeMode = PictureBoxSizeMode.StretchImage;
            sword_equiped.TabIndex = 9;
            sword_equiped.TabStop = false;
            sword_equiped.Visible = false;
            sword_equiped.Click += sword_equiped_Click;
            // 
            // bow_equiped
            // 
            bow_equiped.BackColor = Color.Transparent;
            bow_equiped.Image = Properties.Resources.bow;
            bow_equiped.Location = new Point(140, 317);
            bow_equiped.Name = "bow_equiped";
            bow_equiped.Size = new Size(50, 50);
            bow_equiped.SizeMode = PictureBoxSizeMode.StretchImage;
            bow_equiped.TabIndex = 10;
            bow_equiped.TabStop = false;
            bow_equiped.Visible = false;
            bow_equiped.Click += bow_equiped_Click;
            // 
            // mace_equiped
            // 
            mace_equiped.BackColor = Color.Transparent;
            mace_equiped.Image = Properties.Resources.mace;
            mace_equiped.Location = new Point(197, 317);
            mace_equiped.Name = "mace_equiped";
            mace_equiped.Size = new Size(50, 50);
            mace_equiped.SizeMode = PictureBoxSizeMode.StretchImage;
            mace_equiped.TabIndex = 11;
            mace_equiped.TabStop = false;
            mace_equiped.Visible = false;
            mace_equiped.Click += mace_equiped_Click;
            // 
            // bluePotion_equiped
            // 
            bluePotion_equiped.BackColor = Color.Transparent;
            bluePotion_equiped.Image = Properties.Resources.potion_blue;
            bluePotion_equiped.Location = new Point(254, 317);
            bluePotion_equiped.Name = "bluePotion_equiped";
            bluePotion_equiped.Size = new Size(50, 50);
            bluePotion_equiped.SizeMode = PictureBoxSizeMode.StretchImage;
            bluePotion_equiped.TabIndex = 12;
            bluePotion_equiped.TabStop = false;
            bluePotion_equiped.Visible = false;
            bluePotion_equiped.Click += bluePotion_equiped_Click;
            // 
            // redPotion_equiped
            // 
            redPotion_equiped.BackColor = Color.Transparent;
            redPotion_equiped.Image = Properties.Resources.potion_red;
            redPotion_equiped.Location = new Point(311, 317);
            redPotion_equiped.Name = "redPotion_equiped";
            redPotion_equiped.Size = new Size(50, 50);
            redPotion_equiped.SizeMode = PictureBoxSizeMode.StretchImage;
            redPotion_equiped.TabIndex = 13;
            redPotion_equiped.TabStop = false;
            redPotion_equiped.Visible = false;
            redPotion_equiped.Click += redPotion_equiped_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.2075462F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.7924538F));
            tableLayoutPanel1.Controls.Add(ghoulHitPoints, 1, 3);
            tableLayoutPanel1.Controls.Add(ghostHitPoints, 1, 2);
            tableLayoutPanel1.Controls.Add(batHitPoints, 1, 1);
            tableLayoutPanel1.Controls.Add(playerHitPoints, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(605, 246);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.5454559F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(212, 151);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // ghoulHitPoints
            // 
            ghoulHitPoints.AutoSize = true;
            ghoulHitPoints.Location = new Point(84, 114);
            ghoulHitPoints.Name = "ghoulHitPoints";
            ghoulHitPoints.Size = new Size(106, 20);
            ghoulHitPoints.TabIndex = 15;
            ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // ghostHitPoints
            // 
            ghostHitPoints.AutoSize = true;
            ghostHitPoints.Location = new Point(84, 76);
            ghostHitPoints.Name = "ghostHitPoints";
            ghostHitPoints.Size = new Size(105, 20);
            ghostHitPoints.TabIndex = 16;
            ghostHitPoints.Text = "ghostHitPoints";
            // 
            // batHitPoints
            // 
            batHitPoints.AutoSize = true;
            batHitPoints.Location = new Point(84, 34);
            batHitPoints.Name = "batHitPoints";
            batHitPoints.Size = new Size(90, 20);
            batHitPoints.TabIndex = 17;
            batHitPoints.Text = "batHitPoints";
            // 
            // playerHitPoints
            // 
            playerHitPoints.AutoSize = true;
            playerHitPoints.Location = new Point(84, 0);
            playerHitPoints.Name = "playerHitPoints";
            playerHitPoints.Size = new Size(109, 20);
            playerHitPoints.TabIndex = 18;
            playerHitPoints.Text = "playerHitPoints";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 16;
            label4.Text = "Ghoul";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 76);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 17;
            label5.Text = "Ghost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 15;
            label2.Text = "Bat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Player";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(611, 118);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 15;
            label9.Text = "Attack";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(611, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 16;
            label10.Text = "Move";
            // 
            // move_up
            // 
            move_up.Location = new Point(663, 12);
            move_up.Name = "move_up";
            move_up.Size = new Size(94, 29);
            move_up.TabIndex = 17;
            move_up.Text = "Up";
            move_up.UseVisualStyleBackColor = true;
            move_up.Click += move_up_Click;
            // 
            // move_left
            // 
            move_left.Location = new Point(605, 47);
            move_left.Name = "move_left";
            move_left.Size = new Size(94, 29);
            move_left.TabIndex = 18;
            move_left.Text = "Left";
            move_left.UseVisualStyleBackColor = true;
            move_left.Click += move_left_Click;
            // 
            // move_right
            // 
            move_right.Location = new Point(723, 47);
            move_right.Name = "move_right";
            move_right.Size = new Size(94, 29);
            move_right.TabIndex = 19;
            move_right.Text = "Right";
            move_right.UseVisualStyleBackColor = true;
            move_right.Click += move_right_Click;
            // 
            // move_down
            // 
            move_down.Location = new Point(663, 82);
            move_down.Name = "move_down";
            move_down.Size = new Size(94, 29);
            move_down.TabIndex = 20;
            move_down.Text = "Down";
            move_down.UseVisualStyleBackColor = true;
            move_down.Click += move_down_Click;
            // 
            // attack_down
            // 
            attack_down.Location = new Point(663, 203);
            attack_down.Name = "attack_down";
            attack_down.Size = new Size(94, 29);
            attack_down.TabIndex = 24;
            attack_down.Text = "Down";
            attack_down.UseVisualStyleBackColor = true;
            attack_down.Click += attack_down_Click;
            // 
            // attack_right
            // 
            attack_right.Location = new Point(723, 168);
            attack_right.Name = "attack_right";
            attack_right.Size = new Size(94, 29);
            attack_right.TabIndex = 23;
            attack_right.Text = "Right";
            attack_right.UseVisualStyleBackColor = true;
            attack_right.Click += attack_right_Click;
            // 
            // attack_left
            // 
            attack_left.Location = new Point(605, 168);
            attack_left.Name = "attack_left";
            attack_left.Size = new Size(94, 29);
            attack_left.TabIndex = 22;
            attack_left.Text = "Left";
            attack_left.UseVisualStyleBackColor = true;
            attack_left.Click += attack_left_Click;
            // 
            // attack_up
            // 
            attack_up.Location = new Point(663, 133);
            attack_up.Name = "attack_up";
            attack_up.Size = new Size(94, 29);
            attack_up.TabIndex = 21;
            attack_up.Text = "Up";
            attack_up.UseVisualStyleBackColor = true;
            attack_up.Click += attack_up_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dungeon600x400;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(818, 401);
            Controls.Add(attack_down);
            Controls.Add(attack_right);
            Controls.Add(attack_left);
            Controls.Add(attack_up);
            Controls.Add(move_down);
            Controls.Add(move_right);
            Controls.Add(move_left);
            Controls.Add(move_up);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(player_picture);
            Controls.Add(redPotion_equiped);
            Controls.Add(bluePotion_equiped);
            Controls.Add(mace_equiped);
            Controls.Add(bow_equiped);
            Controls.Add(sword_equiped);
            Controls.Add(bluePotion_picture);
            Controls.Add(redPotion_picture);
            Controls.Add(bat_picture);
            Controls.Add(ghost_picture);
            Controls.Add(ghoul_picture);
            Controls.Add(sword_picture);
            Controls.Add(bow_picture);
            Controls.Add(mace_picture);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sword_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghoul_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghost_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bat_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)redPotion_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bluePotion_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)mace_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bow_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)sword_equiped).EndInit();
            ((System.ComponentModel.ISupportInitialize)bow_equiped).EndInit();
            ((System.ComponentModel.ISupportInitialize)mace_equiped).EndInit();
            ((System.ComponentModel.ISupportInitialize)bluePotion_equiped).EndInit();
            ((System.ComponentModel.ISupportInitialize)redPotion_equiped).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sword_picture;
        private PictureBox ghoul_picture;
        private PictureBox ghost_picture;
        private PictureBox bat_picture;
        private PictureBox player_picture;
        private PictureBox redPotion_picture;
        private PictureBox bluePotion_picture;
        private PictureBox mace_picture;
        private PictureBox bow_picture;
        private PictureBox sword_equiped;
        private PictureBox bow_equiped;
        private PictureBox mace_equiped;
        private PictureBox bluePotion_equiped;
        private PictureBox redPotion_equiped;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label ghoulHitPoints;
        private Label ghostHitPoints;
        private Label batHitPoints;
        private Label playerHitPoints;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label9;
        private Label label10;
        private Button move_up;
        private Button move_left;
        private Button move_right;
        private Button move_down;
        private Button attack_down;
        private Button attack_right;
        private Button attack_left;
        private Button attack_up;
    }
}
