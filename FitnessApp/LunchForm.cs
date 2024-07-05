using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class LunchForm : Form
    {
        public LunchForm()
        {
            this.Location = new Point(0, 0);
            InitializeComponent();
            RefreshData();
        }

        FileIO fileIO = new FileIO();

        private void BreakfastForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void RefreshData()
        {
            product_listb.Items.Clear();
            product_listb.Items.AddRange(fileIO.GetData("products.txt"));

            calories_textb.Clear();
            weight_textb.Clear();

            SetTextBoxData();
        }

        public int GetCalories()
        {
            try
            {
                int calories = int.Parse(calories_textb.Text);
                return calories;
            }
            catch
            {
                return 0;
            }
        }

        public int GetWeight()
        {
            try
            {
                int weight = int.Parse(weight_textb.Text);
                return weight;
            }
            catch
            {
                return 0;
            }

        }
        public string GetProduct()
        {
            try
            {
                string product = product_listb.Text;
                return product;
            }
            catch
            {
                return null;
            }
        }

        public int CountCalories()
        {
            int calories = GetWeight() * GetCalories() / 100;
            return calories;
        }

        public void SetTextBoxData()
        {
            string[] text = fileIO.GetData("lunch.txt");
            string separator = "\r\n";
            data_textb.Text = string.Join(separator, text);

        }

        private void done_b_Click_1(object sender, EventArgs e)
        {
            fileIO.WriteLunchData(this);
            SetTextBoxData();
            RefreshData();
        }

        private void diary_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiaryForm diaryForm = new DiaryForm();
            diaryForm.Location = new Point(0, 0);
            diaryForm.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Location = new Point(0, 0);
            settingsForm.Show();
        }

        private void trackerBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimerForm timerForm = new TimerForm();
            timerForm.Location = new Point(0, 0);
            timerForm.Show();
        }
    }
}
