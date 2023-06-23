using Microsoft.VisualBasic;
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
    public partial class VocabularyDict : Form
    {
        private SoundPlayer soundPlayer;
        public VocabularyDict()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("D:/C#/Data/Data for english game/cute.wav");
            LoadVocabulary();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volume_off_Click(object sender, EventArgs e)
        {
            btn_volume_off.Visible = false;
            btn_volume_up.Visible = true;
            soundPlayer.Play();
            soundPlayer.PlayLooping();
        }

        private void btn_volume_up_Click(object sender, EventArgs e)
        {
            btn_volume_off.Visible = true;
            btn_volume_up.Visible = false;
            soundPlayer.Stop();
        }

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

        private void LoadVocabulary()
        {
            listViewVocabulary.Items.Clear();

            foreach (var entry in vocab)
            {
                var listViewItem = new ListViewItem(entry.Key);
                listViewVocabulary.Items.Add(listViewItem);
            }
        }

        private void btnUpdateVocabulary_Click(object sender, EventArgs e)
        {
            string newWord = Interaction.InputBox("Enter new word:", "Update new word", "");

            if (!string.IsNullOrEmpty(newWord))
            {
                // Kiểm tra xem từ vựng đã tồn tại hay chưa
                if (!vocab.ContainsKey(newWord))
                {
                    // Thêm từ vựng mới vào bộ từ vựng
                    vocab.Add(newWord, "");

                    // Lưu trữ bộ từ vựng đã cập nhật
                    SaveVocabularyToStorage();

                    MessageBox.Show("Updated successfully!");
                }
                else
                {
                    MessageBox.Show("This word is already in the dictionary!");
                }
            }
        }

        private void SaveVocabularyToStorage()
        {
            string filePath = "vocabulary.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var entry in vocab)
                    {
                        writer.WriteLine(entry.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_homepage_back_Click(object sender, EventArgs e)
        {
            Hide();
            modeForm back = new modeForm();
            back.Show();
        }
    }
}
