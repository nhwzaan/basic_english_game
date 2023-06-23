namespace th03
{
    partial class VocabularyDict
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabularyDict));
            btn_exit = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_volume_up = new PictureBox();
            btn_volume_off = new PictureBox();
            listViewVocabulary = new ListView();
            pictureBox2 = new PictureBox();
            btnUpdateVocabulary = new PictureBox();
            btn_homepage_back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateVocabulary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_homepage_back).BeginInit();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.Image = Properties.Resources._728918_cancel_error_exit_fault_alert_icon;
            btn_exit.Location = new Point(1158, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(50, 46);
            btn_exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Be Vietnam Pro ExtraBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(236, 112, 99);
            label1.Location = new Point(469, 136);
            label1.Name = "label1";
            label1.Size = new Size(383, 46);
            label1.TabIndex = 6;
            label1.Text = "KAZUHA'S DICTIONARY\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(865, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_volume_up
            // 
            btn_volume_up.BackColor = Color.White;
            btn_volume_up.Image = Properties.Resources._7122347_up_volume_icon;
            btn_volume_up.Location = new Point(12, 637);
            btn_volume_up.Name = "btn_volume_up";
            btn_volume_up.Size = new Size(64, 44);
            btn_volume_up.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_up.TabIndex = 8;
            btn_volume_up.TabStop = false;
            btn_volume_up.Click += btn_volume_up_Click;
            // 
            // btn_volume_off
            // 
            btn_volume_off.BackColor = Color.White;
            btn_volume_off.Image = Properties.Resources._7122362_off_volume_icon;
            btn_volume_off.Location = new Point(12, 637);
            btn_volume_off.Name = "btn_volume_off";
            btn_volume_off.Size = new Size(64, 44);
            btn_volume_off.SizeMode = PictureBoxSizeMode.Zoom;
            btn_volume_off.TabIndex = 9;
            btn_volume_off.TabStop = false;
            btn_volume_off.Visible = false;
            btn_volume_off.Click += btn_volume_off_Click;
            // 
            // listViewVocabulary
            // 
            listViewVocabulary.Location = new Point(222, 206);
            listViewVocabulary.Name = "listViewVocabulary";
            listViewVocabulary.Size = new Size(808, 230);
            listViewVocabulary.TabIndex = 10;
            listViewVocabulary.UseCompatibleStateImageBehavior = false;
            listViewVocabulary.View = View.List;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(222, 448);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnUpdateVocabulary
            // 
            btnUpdateVocabulary.BackColor = Color.Transparent;
            btnUpdateVocabulary.Image = (Image)resources.GetObject("btnUpdateVocabulary.Image");
            btnUpdateVocabulary.Location = new Point(481, 458);
            btnUpdateVocabulary.Name = "btnUpdateVocabulary";
            btnUpdateVocabulary.Size = new Size(320, 123);
            btnUpdateVocabulary.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdateVocabulary.TabIndex = 12;
            btnUpdateVocabulary.TabStop = false;
            btnUpdateVocabulary.Click += btnUpdateVocabulary_Click;
            // 
            // btn_homepage_back
            // 
            btn_homepage_back.BackColor = Color.Transparent;
            btn_homepage_back.Image = (Image)resources.GetObject("btn_homepage_back.Image");
            btn_homepage_back.Location = new Point(1102, 12);
            btn_homepage_back.Name = "btn_homepage_back";
            btn_homepage_back.Size = new Size(50, 46);
            btn_homepage_back.SizeMode = PictureBoxSizeMode.Zoom;
            btn_homepage_back.TabIndex = 13;
            btn_homepage_back.TabStop = false;
            btn_homepage_back.Click += btn_homepage_back_Click;
            // 
            // VocabularyDict
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cream_Cute_Happy_Birthday_Card__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 693);
            Controls.Add(btn_homepage_back);
            Controls.Add(btnUpdateVocabulary);
            Controls.Add(pictureBox2);
            Controls.Add(listViewVocabulary);
            Controls.Add(btn_volume_off);
            Controls.Add(btn_volume_up);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VocabularyDict";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VocabularyDict";
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_volume_off).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateVocabulary).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_homepage_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_exit;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btn_volume_up;
        private PictureBox btn_volume_off;
        private ListView listViewVocabulary;
        private PictureBox pictureBox2;
        private PictureBox btnUpdateVocabulary;
        private PictureBox btn_homepage_back;
    }
}