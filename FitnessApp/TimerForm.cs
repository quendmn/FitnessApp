using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace FitnessApp
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
            state.Text = "";
            label1.Text = "_____";
            hours.Text = "16";
            minutes.Text = "00";
            seconds.Text = "00";
            
        }
        int h = 16, m = 0, s = 0;

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void restart_b_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "_____";
            state.Text = "";
            hours.Text = "0";
            minutes.Text = "0";
            seconds.Text = "0";
        }

        private void start_b_Click(object sender, EventArgs e)
        {
            int h = 16;
            int m = 0;
            int s = 0;

            timer1.Start();
            label1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            state.Text = "вы голодаете. осталось еще:";
            
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1) 
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                state.Text = "время голода закончилось!";
            }

            hours.Text = Convert.ToString(h);
            minutes.Text = Convert.ToString(m);
            seconds.Text = Convert.ToString(s);
        }
        private void diaryBut_Click(object sender, EventArgs e)
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
    }
}