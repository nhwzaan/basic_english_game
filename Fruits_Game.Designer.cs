namespace th03
{
    partial class Fruits_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruits_Game));
            pb_fruits_game = new PictureBox();
            btnNext = new Button();
            txtAnswer = new TextBox();
            btn_volume_off = new PictureBox();
            btn_volume_up = new PictureBox();
            btn_exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_fruits_game).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            SuspendLayout();
            // 
            // pb_fruits_game
            // 
            pb_fruits_game.BackColor = Color.Transparent;
            pb_fruits_game.Location = new Point(475, 139);
            pb_fruits_game.Name = "pb_fruits_game";
            pb_fruits_game.Size = new Size(312, 272);
            pb_fruits_game.SizeMode = PictureBoxSizeMode.Zoom;
            pb_fruits_game.TabIndex = 6;
            pb_fruits_game.TabStop = false;
            pb_fruits_game.Click += pb_fruits_game_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.FlatAppearance.BorderColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Be Vietnam Pro SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.FromArgb(236, 112, 99);
            btnNext.Location = new Point(566, 486);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(139, 58);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_2;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(520, 426);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(233, 54);
            txtAnswer.TabIndex = 9;
            // 
            // btn_volume_off
            // 
            btn_volume_off.BackColor = Color.White;
            btn_volume_off.Image = Properties.Resources._7122362_off_volume_icon;
            btn_volume_off.Location = new Point(12, 637);
            btn_volume_off.Name = "btn_volume_off";
            btn_volume_off.Size = new Size(64, 44);
            btn_volume_off.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_off.TabIndex = 11;
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
            btn_volume_up.TabIndex = 12;
            btn_volume_up.TabStop = false;
            btn_volume_up.Click += btn_volume_up_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.WhiteSmoke;
            btn_exit.Image = Properties.Resources._728918_cancel_error_exit_fault_alert_icon;
            btn_exit.Location = new Point(1158, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(50, 46);
            btn_exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exit.TabIndex = 14;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Fruits_Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 693);
            Controls.Add(btn_exit);
            Controls.Add(btn_volume_up);
            Controls.Add(btn_volume_off);
            Controls.Add(btnNext);
            Controls.Add(txtAnswer);
            Controls.Add(pb_fruits_game);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Fruits_Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fruits_Game";
            Load += Fruits_Game_Load;
            ((System.ComponentModel.ISupportInitialize)pb_fruits_game).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_fruits_game;
        private Button btnNext;
        private TextBox txtAnswer;
        private PictureBox btn_volume_off;
        private PictureBox btn_volume_up;
        private PictureBox btn_exit;
    }
}