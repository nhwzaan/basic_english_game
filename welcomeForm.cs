using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.Windows.Forms;

namespace th03
{
    public partial class welcomeForm : Form
    {
        private SoundPlayer soundPlayer;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
            (
                int leftRect,
                int topRect,
                int rightRect,
                int bottomRect,
                int widthEllipse,
                int heightEllipse
                );
        public welcomeForm()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("D:/C#/Data/Data for english game/cute.wav");
            //soundPlayer = new SoundPlayer("C:/Sounds/music.wav");
            //soundPlayer.Play();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRect(0, 0, Width, Height, 7, 7));

        }

        int counter = 0;
        int len = 0;
        string textWelcome;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_welcome.Text = textWelcome.Substring(0, counter);
            ++counter;
            if (counter > len)
            {
                label_slogan.Show();
                btn_entergame.Show();
                timer1.Stop();
            }
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            label_slogan.Hide();
            textWelcome = label_welcome.Text;
            len = textWelcome.Length;
            label_welcome.Text = "";
            timer1.Start();
            //soundPlayer.Play();
            soundPlayer.PlayLooping();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volume_up_Click(object sender, EventArgs e)
        {
            btn_volume_off.Visible = true;
            btn_volume_up.Visible = false;
            soundPlayer.Stop();
        }

        private void btn_volume_off_Click(object sender, EventArgs e)
        {
            btn_volume_off.Visible = false;
            btn_volume_up.Visible = true;
            soundPlayer.Play();
        }

        private void btn_entergame_Click(object sender, EventArgs e)
        {
            Hide();
            modeForm chooseMode = new modeForm();
            chooseMode.Show();
        }
    }


}