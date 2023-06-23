namespace th03
{
    partial class welcomeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            pictureBox1 = new PictureBox();
            label_welcome = new Label();
            label_slogan = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_volume_up = new PictureBox();
            btn_exit = new PictureBox();
            btn_volume_off = new PictureBox();
            btn_entergame = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_entergame).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.kzh2;
            pictureBox1.Location = new Point(527, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.BackColor = Color.White;
            label_welcome.Font = new Font("Be Vietnam Pro Black", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_welcome.ForeColor = Color.FromArgb(236, 112, 99);
            label_welcome.Location = new Point(326, 365);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(613, 65);
            label_welcome.TabIndex = 1;
            label_welcome.Text = "KAZUHA'S ENGLISH GAME";
            // 
            // label_slogan
            // 
            label_slogan.AutoSize = true;
            label_slogan.BackColor = Color.White;
            label_slogan.Font = new Font("Be Vietnam Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_slogan.ForeColor = Color.FromArgb(148, 49, 38);
            label_slogan.Location = new Point(480, 430);
            label_slogan.Name = "label_slogan";
            label_slogan.Size = new Size(330, 30);
            label_slogan.TabIndex = 2;
            label_slogan.Text = "Click the button bellow to play ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_volume_up
            // 
            btn_volume_up.BackColor = Color.Transparent;
            btn_volume_up.Image = Properties.Resources._7122347_up_volume_icon;
            btn_volume_up.Location = new Point(12, 637);
            btn_volume_up.Name = "btn_volume_up";
            btn_volume_up.Size = new Size(64, 44);
            btn_volume_up.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_up.TabIndex = 3;
            btn_volume_up.TabStop = false;
            btn_volume_up.Click += btn_volume_up_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.Location = new Point(1158, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(50, 46);
            btn_exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exit.TabIndex = 4;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_volume_off
            // 
            btn_volume_off.BackColor = Color.Transparent;
            btn_volume_off.Image = Properties.Resources._7122362_off_volume_icon;
            btn_volume_off.Location = new Point(12, 637);
            btn_volume_off.Name = "btn_volume_off";
            btn_volume_off.Size = new Size(64, 44);
            btn_volume_off.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_off.TabIndex = 5;
            btn_volume_off.TabStop = false;
            btn_volume_off.Visible = false;
            btn_volume_off.Click += btn_volume_off_Click;
            // 
            // btn_entergame
            // 
            btn_entergame.BackColor = Color.Transparent;
            btn_entergame.Image = (Image)resources.GetObject("btn_entergame.Image");
            btn_entergame.Location = new Point(527, 450);
            btn_entergame.Name = "btn_entergame";
            btn_entergame.Size = new Size(208, 90);
            btn_entergame.SizeMode = PictureBoxSizeMode.Zoom;
            btn_entergame.TabIndex = 7;
            btn_entergame.TabStop = false;
            btn_entergame.Visible = false;
            btn_entergame.Click += btn_entergame_Click;
            // 
            // welcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cream_Cute_Happy_Birthday_Card__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 693);
            Controls.Add(btn_volume_off);
            Controls.Add(btn_exit);
            Controls.Add(btn_volume_up);
            Controls.Add(label_slogan);
            Controls.Add(label_welcome);
            Controls.Add(pictureBox1);
            Controls.Add(btn_entergame);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "welcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAZUHA'S ENGLISH GAME";
            Load += welcomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_entergame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label_welcome;
        private Label label_slogan;
        private System.Windows.Forms.Timer timer1;
        private PictureBox btn_volume_up;
        private PictureBox btn_exit;
        private PictureBox btn_volume_off;
        private PictureBox btn_entergame;
    }
}