using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th03
{
    public partial class Ranking : Form
    {
        private SoundPlayer soundPlayer;
        public Ranking()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("D:/C#/Data/Data for english game/cute.wav");
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
            soundPlayer.PlayLooping();
        }

        private void btn_homepage_back_Click(object sender, EventArgs e)
        {
            Hide();
            modeForm newform = new modeForm();
            newform.Show();
        }
    }
}
