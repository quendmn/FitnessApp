using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class SettingsForm : Form
    {
        FileIO fileIO = new FileIO();

        public static int calories;
        public SettingsForm()
        {
            InitializeComponent();
            calories = fileIO.ChangeCalories();
        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            fileIO.SaveData();
            fileIO.ClearData();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void done_b_Click(object sender, EventArgs e)
        {
            fileIO.ChangeCalories();
            StreamWriter sw = new StreamWriter("calories.txt", false);
            if (calories_tb.Text != "")
            {
                sw.Write(calories_tb.Text);
                calories_tb.Clear();
                sw.Close();
                MessageBox.Show("норма изменена!");
            }
        
        }

        private void diaryBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiaryForm diaryForm = new DiaryForm();
            diaryForm.Location = new Point(0, 0);
            diaryForm.Show();

        }

        private void trackerBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimerForm timerForm = new TimerForm();
            timerForm.Location = new Point(0, 0);
            timerForm.Show();
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            if(delete_tb.Text != "")
            {
                fileIO.DeleteProduct(delete_tb.Text);
                delete_tb.Clear();
                MessageBox.Show("продукт удален!");
            }           
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            if(add_tb.Text != "")
            {
                fileIO.AddProduct(add_tb.Text);
                add_tb.Clear();
                MessageBox.Show("продукт добавлен!");
            }

        }
    }
}
