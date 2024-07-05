namespace FitnessApp
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.diaryPic = new System.Windows.Forms.PictureBox();
            this.diaryBut = new System.Windows.Forms.Button();
            this.trackerPic = new System.Windows.Forms.PictureBox();
            this.trackerBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_b = new System.Windows.Forms.Button();
            this.hours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.restart_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(187)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 85);
            this.panel1.TabIndex = 25;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(201, 29);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(596, 40);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "таймер интервального голодания 16:8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(399, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 35);
            this.button5.TabIndex = 22;
            this.button5.Text = "настройки";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // diaryPic
            // 
            this.diaryPic.Image = ((System.Drawing.Image)(resources.GetObject("diaryPic.Image")));
            this.diaryPic.Location = new System.Drawing.Point(693, 5);
            this.diaryPic.Name = "diaryPic";
            this.diaryPic.Size = new System.Drawing.Size(40, 40);
            this.diaryPic.TabIndex = 19;
            this.diaryPic.TabStop = false;
            // 
            // diaryBut
            // 
            this.diaryBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.diaryBut.FlatAppearance.BorderSize = 0;
            this.diaryBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.diaryBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.diaryBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diaryBut.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diaryBut.ForeColor = System.Drawing.Color.Black;
            this.diaryBut.Location = new System.Drawing.Point(660, 47);
            this.diaryBut.Name = "diaryBut";
            this.diaryBut.Size = new System.Drawing.Size(115, 35);
            this.diaryBut.TabIndex = 20;
            this.diaryBut.Text = "дневник";
            this.diaryBut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.diaryBut.UseVisualStyleBackColor = true;
            this.diaryBut.Click += new System.EventHandler(this.diaryBut_Click);
            // 
            // trackerPic
            // 
            this.trackerPic.Image = ((System.Drawing.Image)(resources.GetObject("trackerPic.Image")));
            this.trackerPic.Location = new System.Drawing.Point(208, 5);
            this.trackerPic.Name = "trackerPic";
            this.trackerPic.Size = new System.Drawing.Size(40, 40);
            this.trackerPic.TabIndex = 18;
            this.trackerPic.TabStop = false;
            // 
            // trackerBut
            // 
            this.trackerBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackerBut.FlatAppearance.BorderSize = 0;
            this.trackerBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.trackerBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.trackerBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trackerBut.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackerBut.ForeColor = System.Drawing.Color.Black;
            this.trackerBut.Location = new System.Drawing.Point(182, 47);
            this.trackerBut.Name = "trackerBut";
            this.trackerBut.Size = new System.Drawing.Size(104, 35);
            this.trackerBut.TabIndex = 18;
            this.trackerBut.Text = "таймер";
            this.trackerBut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.trackerBut.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(187)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.diaryPic);
            this.panel2.Controls.Add(this.diaryBut);
            this.panel2.Controls.Add(this.trackerPic);
            this.panel2.Controls.Add(this.trackerBut);
            this.panel2.Location = new System.Drawing.Point(-1, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 85);
            this.panel2.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_b
            // 
            this.start_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start_b.FlatAppearance.BorderSize = 0;
            this.start_b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.start_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.start_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_b.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_b.ForeColor = System.Drawing.Color.Black;
            this.start_b.Location = new System.Drawing.Point(305, 339);
            this.start_b.Name = "start_b";
            this.start_b.Size = new System.Drawing.Size(141, 44);
            this.start_b.TabIndex = 23;
            this.start_b.Text = "старт";
            this.start_b.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.start_b.UseVisualStyleBackColor = true;
            this.start_b.Click += new System.EventHandler(this.start_b_Click);
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hours.Location = new System.Drawing.Point(307, 197);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(74, 66);
            this.hours.TabIndex = 26;
            this.hours.Text = "16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(387, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 66);
            this.label2.TabIndex = 27;
            this.label2.Text = ":";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutes.Location = new System.Drawing.Point(431, 197);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(74, 66);
            this.minutes.TabIndex = 28;
            this.minutes.Text = "16";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seconds.Location = new System.Drawing.Point(555, 197);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(74, 66);
            this.seconds.TabIndex = 29;
            this.seconds.Text = "16";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(511, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 66);
            this.label5.TabIndex = 30;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(303, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 33);
            this.label6.TabIndex = 31;
            this.label6.Text = "часов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(426, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 33);
            this.label7.TabIndex = 32;
            this.label7.Text = "минут";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(549, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 33;
            this.label8.Text = "секунд";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state.Location = new System.Drawing.Point(290, 130);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(91, 33);
            this.state.TabIndex = 34;
            this.state.Text = "минут";
            // 
            // restart_b
            // 
            this.restart_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restart_b.FlatAppearance.BorderSize = 0;
            this.restart_b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.restart_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(154)))));
            this.restart_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_b.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart_b.ForeColor = System.Drawing.Color.Black;
            this.restart_b.Location = new System.Drawing.Point(498, 339);
            this.restart_b.Name = "restart_b";
            this.restart_b.Size = new System.Drawing.Size(141, 44);
            this.restart_b.TabIndex = 35;
            this.restart_b.Text = "сброс";
            this.restart_b.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.restart_b.UseVisualStyleBackColor = true;
            this.restart_b.Click += new System.EventHandler(this.restart_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(430, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "_____";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restart_b);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.start_b);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerForm";
            this.Text = "FitnessApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimerForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox diaryPic;
        private System.Windows.Forms.Button diaryBut;
        private System.Windows.Forms.PictureBox trackerPic;
        private System.Windows.Forms.Button trackerBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_b;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Button restart_b;
        private System.Windows.Forms.Label label1;
    }
}