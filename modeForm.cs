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
    public partial class modeForm : Form
    {
        private SoundPlayer soundPlayer;
        public modeForm()
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

        private void pb_animals_Click(object sender, EventArgs e)
        {
            Hide();
            Game animalGame = new Game();
            animalGame.Show();
        }

        private void pb_fruits_Click(object sender, EventArgs e)
        {
            Hide();
            Fruits_Game fruitsgame = new Fruits_Game();
            fruitsgame.Show();
        }

        private void pb_food_Click(object sender, EventArgs e)
        {
            Hide();
            Food_Game foodgame = new Food_Game();
            foodgame.Show();
        }

        private void pb_jobs_Click(object sender, EventArgs e)
        {
            Hide();
            Jobs_Game jobs_Game = new Jobs_Game();
            jobs_Game.Show();

        }

        private void label_animals_Click(object sender, EventArgs e)
        {
            Hide();
            Game animalGame = new Game();
            animalGame.Show();
        }

        private void label_fruits_Click(object sender, EventArgs e)
        {
            Hide();
            Fruits_Game fruitsgame = new Fruits_Game();
            fruitsgame.Show();
        }

        private void label_food_Click(object sender, EventArgs e)
        {
            Hide();
            Food_Game foodgame = new Food_Game();
            foodgame.Show();
        }

        private void label_jobs_Click(object sender, EventArgs e)
        {
            Hide();
            Jobs_Game jobs_Game = new Jobs_Game();
            jobs_Game.Show();

        }

        private void label_lv_easy_Click(object sender, EventArgs e)
        {
            panel_level.Visible = false;
        }

        private void label_lv_medium_Click(object sender, EventArgs e)
        {
            panel_level.Visible = false;
        }

        private void label_lv_hard_Click(object sender, EventArgs e)
        {
            panel_level.Visible = false;
        }

        private void pb_easy_Click(object sender, EventArgs e)
        {
            panel_level.Visible = false;
        }

        private void pb_medium_Click(object sender, EventArgs e)
        {
            panel_level.Visible = false;
        }

        private void pb_hard_Click(object sender, EventArgs e)
        {
            panel_level.Visible = false;
        }

        private void lbl_dict_Click(object sender, EventArgs e)
        {
            Hide();
            VocabularyDict vocab = new VocabularyDict();
            vocab.Show();
        }

        private void pb_dict_Click(object sender, EventArgs e)
        {
            Hide();
            VocabularyDict vocab = new VocabularyDict();
            vocab.Show();
        }

        private void lbl_ranking_Click(object sender, EventArgs e)
        {
            Hide();
            Ranking rank = new Ranking();
            rank.Show();
        }

        private void pb_ranking_Click(object sender, EventArgs e)
        {
            Hide();
            Ranking rank = new Ranking();
            rank.Show();
        }
    }
}
