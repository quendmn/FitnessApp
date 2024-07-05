using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class DiaryForm : Form
    {
        FileIO fileIO = new FileIO();        
        public DiaryForm()
        {
            InitializeComponent();
            LocateForms();
            LocateDate();
            ShowCalories();
           
        }

        private void LocateForms()
        {
            Point p = new Point(0, 0);
            this.Location = p;
        }

        private void DiaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LocateDate()
        {
            dateLabel.Text = DateTime.Now.ToString("dd.MM, dddd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BreakfastForm breakfastForm = new BreakfastForm();
            breakfastForm.Location = new Point(0, 0);
            breakfastForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DinnerForm dinnerForm = new DinnerForm();
            dinnerForm.Location = new Point(0, 0);
            dinnerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LunchForm lunchForm = new LunchForm();
            lunchForm.Location = new Point(0, 0);
            lunchForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtherForm otherForm = new OtherForm();
            otherForm.Location = new Point(0, 0);
            otherForm.Show();
        }

        private void ShowCalories()
        {
            breakfast_calories.Text = fileIO.GetCaloriesString("breakfast.txt") + " ккал";
            lunch_calories.Text = fileIO.GetCaloriesString("lunch.txt") + " ккал";
            dinner_calories.Text = fileIO.GetCaloriesString("dinner.txt") + " ккал";
            other_calories.Text = fileIO.GetCaloriesString("other.txt") + " ккал";

            total_calories.Text = fileIO.GetTotalCalories() + $"/ {fileIO.ChangeCalories()}";
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
