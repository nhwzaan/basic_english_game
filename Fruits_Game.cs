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
    public partial class Fruits_Game : Form
    {
        private Dictionary<string, string> vocab = new Dictionary<string, string>()
        {
            {"apple", "D:/C#/Data/Data for english game/Fruits/apple.png"},
            {"avocado", "D:/C#/Data/Data for english game/Fruits/avocado.png" },
            {"banana", "D:/C#/Data/Data for english game/Fruits/banana.png"},
            {"cherry", "D:/C#/Data/Data for english game/Fruits/cherry.jpg"},
            {"durian", "D:/C#/Data/Data for english game/Fruits/durian.png"},
            {"grape", "D:/C#/Data/Data for english game/Fruits/grape.png"},
            {"kiwi", "D:/C#/Data/Data for english game/Fruits/kiwi.png"},
            {"lemon", "D:/C#/Data/Data for english game/Fruits/lemon.png"},
            {"mango", "D:/C#/Data/Data for english game/Fruits/mango.png"},
            {"orange", "D:/C#/Data/Data for english game/Fruits/orange.png"},
            {"peach", "D:/C#/Data/Data for english game/Fruits/peach.png"},
            {"pear", "D:/C#/Data/Data for english game/Fruits/pear.png"},
            {"pineapple", "D:/C#/Data/Data for english game/Fruits/pineapple.png"},
            {"strawberry", "D:/C#/Data/Data for english game/Fruits/strawberry.png"},
            {"watermelon", "D:/C#/Data/Data for english game/Fruits/watermelon.png"},
        };

        private SoundPlayer soundPlayer;
        public Fruits_Game()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("D:/C#/Data/Data for english game/cute.wav");
        }

        private List<string> words;
        private int currentWordIndex;
        private int score;

        private void btn_volume_up_Click(object sender, EventArgs e)
        {
            btn_volume_up.Visible = false;
            btn_volume_off.Visible = true;
            soundPlayer.Stop();

        }

        private void btn_volume_off_Click(object sender, EventArgs e)
        {
            btn_volume_up.Visible = true;
            btn_volume_off.Visible = false;
            soundPlayer.Play();
            soundPlayer.PlayLooping();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fruits_Game_Load(object sender, EventArgs e)
        {
            words = new List<string>(vocab.Keys);
            ShuffleWords();
            score = 0;
            currentWordIndex = 0;
            ShowCurrentWord();
        }

        private void ShuffleWords()
        {
            Random random = new Random();
            int n = words.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = words[k];
                words[k] = words[n];
                words[n] = value;
            }
        }

        private void ShowCurrentWord()
        {
            if (currentWordIndex < 5)
            {
                string word = words[currentWordIndex];
                string imagePath = vocab[word];

                //lblVocabulary.Text = word;
                pb_fruits_game.Image = Image.FromFile(imagePath);
                txtAnswer.Text = string.Empty;
                txtAnswer.Focus();
            }
            else
            {
                //pb_nahida.Visible = true;
                MessageBox.Show("End your turn! Your score is: " + score);
                Hide();
                modeForm back = new modeForm();
                back.Show();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            string word = words[currentWordIndex];
            string userAnswer = txtAnswer.Text.Trim().ToLower();

            if (userAnswer == word)
            {
                score += 2;
            }

            currentWordIndex++;
            ShowCurrentWord();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            string word = words[currentWordIndex];
            string userAnswer = txtAnswer.Text.Trim().ToLower();

            if (userAnswer == word)
            {
                score += 2;
            }

            currentWordIndex++;
            ShowCurrentWord();
        }

        private void btnNext_Click_2(object sender, EventArgs e)
        {
            string word = words[currentWordIndex];
            string userAnswer = txtAnswer.Text.Trim().ToLower();

            if (userAnswer == word)
            {
                score += 20;
            }

            currentWordIndex++;
            ShowCurrentWord();
        }

        private void pb_fruits_game_Click(object sender, EventArgs e)
        {

        }
    }
}
