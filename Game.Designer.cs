namespace th03
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            ListViewItem listViewItem1 = new ListViewItem("");
            btn_exit = new PictureBox();
            btn_volume_off = new PictureBox();
            btn_volume_up = new PictureBox();
            pb_animal_game = new PictureBox();
            txtAnswer = new TextBox();
            lblVocabulary = new Label();
            btnNext = new Button();
            pb_ucandoit = new PictureBox();
            pb_great = new PictureBox();
            panel_animal_ranking = new Panel();
            listViewScore = new ListView();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_animal_game).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ucandoit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_great).BeginInit();
            panel_animal_ranking.SuspendLayout();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.WhiteSmoke;
            btn_exit.Image = Properties.Resources._728918_cancel_error_exit_fault_alert_icon;
            btn_exit.Location = new Point(1158, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(50, 46);
            btn_exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exit.TabIndex = 1;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_volume_off
            // 
            btn_volume_off.BackColor = Color.White;
            btn_volume_off.Image = Properties.Resources._7122362_off_volume_icon;
            btn_volume_off.Location = new Point(12, 637);
            btn_volume_off.Name = "btn_volume_off";
            btn_volume_off.Size = new Size(64, 44);
            btn_volume_off.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_off.TabIndex = 4;
            btn_volume_off.TabStop = false;
            btn_volume_off.Visible = false;
            btn_volume_off.Click += btn_volume_off_Click;
            // 
            // btn_volume_up
            // 
            btn_volume_up.BackColor = Color.White;
            btn_volume_up.Image = Properties.Resources._7122347_up_volume_icon;
            btn_volume_up.Location = new Point(12, 637);
            btn_volume_up.Name = "btn_volume_up";
            btn_volume_up.Size = new Size(64, 44);
            btn_volume_up.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_up.TabIndex = 3;
            btn_volume_up.TabStop = false;
            btn_volume_up.Click += btn_volume_up_Click;
            // 
            // pb_animal_game
            // 
            pb_animal_game.BackColor = Color.Transparent;
            pb_animal_game.Location = new Point(445, 71);
            pb_animal_game.Name = "pb_animal_game";
            pb_animal_game.Size = new Size(383, 331);
            pb_animal_game.SizeMode = PictureBoxSizeMode.Zoom;
            pb_animal_game.TabIndex = 5;
            pb_animal_game.TabStop = false;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(526, 408);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(233, 54);
            txtAnswer.TabIndex = 6;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // lblVocabulary
            // 
            lblVocabulary.AutoSize = true;
            lblVocabulary.Location = new Point(26, 12);
            lblVocabulary.Name = "lblVocabulary";
            lblVocabulary.Size = new Size(50, 20);
            lblVocabulary.TabIndex = 7;
            lblVocabulary.Text = "label1";
            lblVocabulary.Visible = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.FlatAppearance.BorderColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.FromArgb(236, 112, 99);
            btnNext.Location = new Point(572, 468);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(139, 58);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // pb_ucandoit
            // 
            pb_ucandoit.BackColor = Color.Transparent;
            pb_ucandoit.Image = (Image)resources.GetObject("pb_ucandoit.Image");
            pb_ucandoit.Location = new Point(958, 110);
            pb_ucandoit.Name = "pb_ucandoit";
            pb_ucandoit.Size = new Size(234, 178);
            pb_ucandoit.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ucandoit.TabIndex = 10;
            pb_ucandoit.TabStop = false;
            // 
            // pb_great
            // 
            pb_great.BackColor = Color.Transparent;
            pb_great.Image = (Image)resources.GetObject("pb_great.Image");
            pb_great.Location = new Point(198, 253);
            pb_great.Name = "pb_great";
            pb_great.Size = new Size(182, 133);
            pb_great.SizeMode = PictureBoxSizeMode.Zoom;
            pb_great.TabIndex = 12;
            pb_great.TabStop = false;
            // 
            // panel_animal_ranking
            // 
            panel_animal_ranking.BackColor = Color.White;
            panel_animal_ranking.Controls.Add(listViewScore);
            panel_animal_ranking.Location = new Point(399, 71);
            panel_animal_ranking.Name = "panel_animal_ranking";
            panel_animal_ranking.Size = new Size(453, 455);
            panel_animal_ranking.TabIndex = 13;
            panel_animal_ranking.Visible = false;
            // 
            // listViewScore
            // 
            listViewScore.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewScore.Location = new Point(58, 39);
            listViewScore.Name = "listViewScore";
            listViewScore.Size = new Size(325, 365);
            listViewScore.TabIndex = 0;
            listViewScore.UseCompatibleStateImageBehavior = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 693);
            Controls.Add(panel_animal_ranking);
            Controls.Add(pb_great);
            Controls.Add(btnNext);
            Controls.Add(lblVocabulary);
            Controls.Add(txtAnswer);
            Controls.Add(pb_animal_game);
            Controls.Add(btn_volume_off);
            Controls.Add(btn_volume_up);
            Controls.Add(btn_exit);
            Controls.Add(pb_ucandoit);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAZUHA'S ENGLISH GAME";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_animal_game).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ucandoit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_great).EndInit();
            panel_animal_ranking.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_exit;
        private PictureBox btn_volume_off;
        private PictureBox btn_volume_up;
        private PictureBox pb_animal_game;
        private TextBox txtAnswer;
        private Label lblVocabulary;
        private Button btnNext;
        private PictureBox pictureBox1;
        private PictureBox pb_ucandoit;
        private PictureBox pb_great;
        private Panel panel_animal_ranking;
        private ListView listViewScore;
    }
}