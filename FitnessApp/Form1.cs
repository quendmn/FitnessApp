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
    public partial class LoadForm : Form
    {
        FileIO fileIO = new FileIO();
        public LoadForm()
        {      
            InitializeComponent();           
            LocateForms();
            
        }
        
        private void LocateForms() {
            Point p = new Point(0,0);
            this.Location = p;    
        }

        private void LoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form diaryForm = new DiaryForm();
            diaryForm.Location = new Point(0, 0);
            diaryForm.Show();
                       
        }
    }
}
