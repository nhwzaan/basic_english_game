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
    public partial class Jobs_Game : Form
    {
        private Dictionary<string, string> vocab = new Dictionary<string, string>()
        {
            {"cook", "D:/C#/Data/Data for english game/Jobs/cook.png"},
            {"dentist", "D:/C#/Data/Data for english game/Jobs/dentist.png" },
            {"developer", "D:/C#/Data/Data for english game/Jobs/developer.png"},
            {"doctor", "D:/C#/Data/Data for english game/Jobs/doctor.png"},
            {"engineer", "D:/C#/Data/Data for english game/Jobs/engineer.png"},
            {"farmer", "D:/C#/Data/Data for english game/Jobs/farmer.png"},
            {"fireman", "D:/C#/Data/Data for english game/Jobs/fireman.png"},
            {"footballer", "D:/C#/Data/Data for english game/Jobs/footballer.png"},
            {"hairdresser", "D:/C#/Data/Data for english game/Jobs/hairdresser.png"},
            {"nurse", "D:/C#/Data/Data for english game/Jobs/nurse.png"},
            {"painter", "D:/C#/Data/Data for english game/Jobs/painter.png"},
            {"pilot", "D:/C#/Data/Data for english game/Jobs/pilot.png"},
            {"scientist", "D:/C#/Data/Data for english game/Jobs/scientist.png"},
            {"singer", "D:/C#/Data/Data for english game/Jobs/singer.png"},
            {"student", "D:/C#/Data/Data for english game/Jobs/student.png"},
            {"teacher", "D:/C#/Data/Data for english game/Jobs/teacher.png"},
            {"waiter", "D:/C#/Data/Data for english game/Jobs/waiter.png"},

        };

        private SoundPlayer soundPlayer;

        public Jobs_Game()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("D:/C#/Data/Data for english game/cute.wav");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volume_off_Click(object sender, EventArgs e)
        {
            btn_volume_up.Visible = true;
            btn_volume_off.Visible = false;
            soundPlayer.Play();
            soundPlayer.PlayLooping();
        }

        private void btn_volume_up_Click(object sender, EventArgs e)
        {
            btn_volume_off.Visible = true;
            btn_volume_up.Visible = false;
            soundPlayer.Stop();
        }

        private List<string> words;
        private int currentWordIndex;
        private int score;

        private void Jobs_Game_Load(object sender, EventArgs e)
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
                pb_jobs_game.Image = Image.FromFile(imagePath);
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
