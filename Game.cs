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
using System.IO;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;
using System.Runtime.InteropServices;


namespace th03
{
    public partial class Game : Form
    {
        private Dictionary<int, int> scoreHistory = new Dictionary<int, int>();
        private int gameCount = 0;
        private Dictionary<string, string> vocab = new Dictionary<string, string>()
        {
            {"bird", "D:/C#/Data/Data for english game/Animals/bird.png"},
            {"butterfly", "D:/C#/Data/Data for english game/Animals/butterfly.png" },
            {"cat", "D:/C#/Data/Data for english game/Animals/cat.jpg"},
            {"chicken", "D:/C#/Data/Data for english game/Animals/chicken.jpg"},
            {"crab", "D:/C#/Data/Data for english game/Animals/crab.jpg"},
            {"dog", "D:/C#/Data/Data for english game/Animals/dog.jpg"},
            {"dolphin", "D:/C#/Data/Data for english game/Animals/dolphin.jpg"},
            {"duck", "D:/C#/Data/Data for english game/Animals/duck.png"},
            {"elephant", "D:/C#/Data/Data for english game/Animals/elephant.png"},
            {"fish", "D:/C#/Data/Data for english game/Animals/fish.png"},
            {"fox", "D:/C#/Data/Data for english game/Animals/fox.png"},
            {"giraffe", "D:/C#/Data/Data for english game/Animals/giraffe.png"},
            {"goat", "D:/C#/Data/Data for english game/Animals/goat.png"},
            {"horse", "D:/C#/Data/Data for english game/Animals/horse.jpg"},
            {"kangaroo", "D:/C#/Data/Data for english game/Animals/kangaroo.png"},
            {"monkey", "D:/C#/Data/Data for english game/Animals/monkey.png"},
            {"panda", "D:/C#/Data/Data for english game/Animals/panda.jpg"},
            {"peacock", "D:/C#/Data/Data for english game/Animals/peacock.png"},
            {"penguin", "D:/C#/Data/Data for english game/Animals/penguin.png"},
            {"pig", "D:/C#/Data/Data for english game/Animals/pig.png"},
            {"shark", "D:/C#/Data/Data for english game/Animals/shark.png"},
            {"sheep", "D:/C#/Data/Data for english game/Animals/sheep.png"},
            {"squid", "D:/C#/Data/Data for english game/Animals/squid.jpg"},
            {"tiger", "D:/C#/Data/Data for english game/Animals/tiger.jpg"},
            {"zebra", "D:/C#/Data/Data for english game/Animals/zebra.png"},
        };


        private SoundPlayer soundPlayer;
        public Game()
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

        private void Game_Load(object sender, EventArgs e)
        {
            words = new List<string>(vocab.Keys);
            ShuffleWords();
            score = 0;
            currentWordIndex = 0;

            LoadScoreHistory();
            gameCount = scoreHistory.Count;
            ConfigureScoreListView();
            LoadScoreHistory();
            ShowCurrentWord();
        }

        private void ConfigureScoreListView()
        {
            listViewScore.View = View.Details;
            listViewScore.Columns.Add("Lần chơi", 80);
            listViewScore.Columns.Add("Điểm số", 80);
        }

        /*private void ShowScoreHistory()
        {
            listViewScore.Items.Clear();

            foreach (var entry in scoreHistory)
            {
                string[] row = { entry.Key.ToString(), entry.Value.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewScore.Items.Add(listViewItem);
            }
        }*/


        private void SaveScoreDataToStorage(Dictionary<int, int> scoreData)
        {
            string filePath = "D:/C#/th03/score.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var entry in scoreData)
                    {
                        writer.WriteLine($"{entry.Key},{entry.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu trữ dữ liệu điểm: " + ex.Message);
            }
        }

        private Dictionary<int, int> ReadScoreDataFromStorage()
        {
            Dictionary<int, int> scoreData = new Dictionary<int, int>();
            string filePath = "D:/C#/th03/score.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            int gameCount = int.Parse(parts[0]);
                            int score = int.Parse(parts[1]);
                            scoreData.Add(gameCount, score);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu điểm: " + ex.Message);
            }

            return scoreData;
        }


        private void LoadScoreHistory()
        {
            // Đọc dữ liệu điểm từ nơi lưu trữ (ví dụ: tệp tin, cơ sở dữ liệu)
            scoreHistory = ReadScoreDataFromStorage();
        }

        private void UpdateScoreHistory(int score)
        {
            gameCount++;
            scoreHistory.Add(gameCount, score);

            // Lưu trữ dữ liệu điểm xuống nơi lưu trữ (ví dụ: tệp tin, cơ sở dữ liệu)
            SaveScoreDataToStorage(scoreHistory);
        }

        private void ShowScoreHistory()
        {
            panel_animal_ranking.Visible = true;
            listViewScore.Items.Clear();

            foreach (var entry in scoreHistory)
            {
                string[] row = { entry.Key.ToString(), entry.Value.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewScore.Items.Add(listViewItem);
            }
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

                lblVocabulary.Text = word;
                pb_animal_game.Image = Image.FromFile(imagePath);
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

            if (currentWordIndex >= words.Count)
            {
                UpdateScoreHistory(score);
                ShowScoreHistory();
               

                MessageBox.Show("Lượt chơi đã kết thúc! Điểm của bạn là: " + score);
                Hide();
            }
            
        }

        

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
