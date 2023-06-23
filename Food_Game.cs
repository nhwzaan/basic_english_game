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
    public partial class Food_Game : Form
    {

        private Dictionary<string, string> vocab = new Dictionary<string, string>()
        {
            {"bread", "D:/C#/Data/Data for english game/Food/bread.png"},
            {"cake", "D:/C#/Data/Data for english game/Food/cake.png" },
            {"cheese", "D:/C#/Data/Data for english game/Food/cheese.png"},
            {"chips", "D:/C#/Data/Data for english game/Food/chips.png"},
            {"chocolate", "D:/C#/Data/Data for english game/Food/chocolate.png"},
            {"cream", "D:/C#/Data/Data for english game/Food/cream.png"},
            {"fried chicken", "D:/C#/Data/Data for english game/Food/fried chicken.png"},
            {"hamburger", "D:/C#/Data/Data for english game/Food/hamburger.png"},
            {"honey", "D:/C#/Data/Data for english game/Food/honey.png"},
            {"juice", "D:/C#/Data/Data for english game/Food/juice.jpg"},
            {"milk", "D:/C#/Data/Data for english game/Food/milk.png"},
            {"pizza", "D:/C#/Data/Data for english game/Food/pizza.png"},
            {"sandwich", "D:/C#/Data/Data for english game/Food/sandwich.png"},
            {"soda", "D:/C#/Data/Data for english game/Food/soda.png"},
        };

        private SoundPlayer soundPlayer;
        public Food_Game()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("D:/C#/Data/Data for english game/cute.wav");
        }

        private List<string> words;
        private int currentWordIndex;
        private int score;

        private void btn_volume_up_Click(object sender, EventArgs e)
        {
            btn_volume_off.Visible = true;
            btn_volume_up.Visible = false;
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

        private void Food_Game_Load(object sender, EventArgs e)
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
                pb_food_game.Image = Image.FromFile(imagePath);
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
                score += 20;
            }

            currentWordIndex++;
            ShowCurrentWord();
        }
    }
}
