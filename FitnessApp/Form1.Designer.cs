namespace FitnessApp
{
    partial class LoadForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.appleBackgr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appleBackgr)).BeginInit();
            this.SuspendLayout();
            // 
            // appleBackgr
            // 
            this.appleBackgr.ErrorImage = ((System.Drawing.Image)(resources.GetObject("appleBackgr.ErrorImage")));
            this.appleBackgr.ImageLocation = "0;0";
            this.appleBackgr.InitialImage = ((System.Drawing.Image)(resources.GetObject("appleBackgr.InitialImage")));
            this.appleBackgr.Location = new System.Drawing.Point(389, 194);
            this.appleBackgr.Margin = new System.Windows.Forms.Padding(0);
            this.appleBackgr.Name = "appleBackgr";
            this.appleBackgr.Size = new System.Drawing.Size(172, 172);
            this.appleBackgr.TabIndex = 0;
            this.appleBackgr.TabStop = false;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.appleBackgr);
            this.Font = new System.Drawing.Font("PP Writer Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoadForm";
            this.Text = "FitnessApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadForm_FormClosing);
            this.Click += new System.EventHandler(this.LoadForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.appleBackgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox appleBackgr;
    }
}

