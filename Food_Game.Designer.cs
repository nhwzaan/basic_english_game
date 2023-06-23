namespace th03
{
    partial class Food_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food_Game));
            pb_food_game = new PictureBox();
            btnNext = new Button();
            txtAnswer = new TextBox();
            btn_volume_up = new PictureBox();
            btn_volume_off = new PictureBox();
            btn_exit = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_food_game).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pb_food_game
            // 
            pb_food_game.BackColor = Color.Transparent;
            pb_food_game.Location = new Point(469, 105);
            pb_food_game.Name = "pb_food_game";
            pb_food_game.Size = new Size(335, 302);
            pb_food_game.SizeMode = PictureBoxSizeMode.Zoom;
            pb_food_game.TabIndex = 6;
            pb_food_game.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.FlatAppearance.BorderColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.FromArgb(236, 112, 99);
            btnNext.Location = new Point(573, 482);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(139, 58);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(524, 422);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(233, 54);
            txtAnswer.TabIndex = 9;
            // 
            // btn_volume_up
            // 
            btn_volume_up.BackColor = Color.Transparent;
            btn_volume_up.Image = Properties.Resources._7122347_up_volume_icon;
            btn_volume_up.Location = new Point(12, 637);
            btn_volume_up.Name = "btn_volume_up";
            btn_volume_up.Size = new Size(64, 44);
            btn_volume_up.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_up.TabIndex = 11;
            btn_volume_up.TabStop = false;
            btn_volume_up.Click += btn_volume_up_Click;
            // 
            // btn_volume_off
            // 
            btn_volume_off.BackColor = Color.Transparent;
            btn_volume_off.Image = Properties.Resources._7122362_off_volume_icon;
            btn_volume_off.Location = new Point(12, 637);
            btn_volume_off.Name = "btn_volume_off";
            btn_volume_off.Size = new Size(64, 44);
            btn_volume_off.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_off.TabIndex = 12;
            btn_volume_off.TabStop = false;
            btn_volume_off.Visible = false;
            btn_volume_off.Click += btn_volume_off_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.WhiteSmoke;
            btn_exit.Image = Properties.Resources._728918_cancel_error_exit_fault_alert_icon;
            btn_exit.Location = new Point(1158, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(50, 46);
            btn_exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exit.TabIndex = 13;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 411);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(936, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 210);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Food_Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 693);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_exit);
            Controls.Add(btn_volume_off);
            Controls.Add(btn_volume_up);
            Controls.Add(btnNext);
            Controls.Add(txtAnswer);
            Controls.Add(pb_food_game);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Food_Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAZUHA'S ENGLISH GAME";
            Load += Food_Game_Load;
            ((System.ComponentModel.ISupportInitialize)pb_food_game).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_food_game;
        private Button btnNext;
        private TextBox txtAnswer;
        private PictureBox btn_volume_up;
        private PictureBox btn_volume_off;
        private PictureBox btn_exit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}