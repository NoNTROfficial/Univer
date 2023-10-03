namespace Assignment_1
{
    partial class programTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programTitle));
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.reminder = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureTitle
            // 
            this.pictureTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureTitle.Image")));
            this.pictureTitle.Location = new System.Drawing.Point(21, 25);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(384, 379);
            this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTitle.TabIndex = 0;
            this.pictureTitle.TabStop = false;
            this.pictureTitle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelTitle.Location = new System.Drawing.Point(515, 45);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(168, 39);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Welcome!";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // reminder
            // 
            this.reminder.AutoSize = true;
            this.reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reminder.Location = new System.Drawing.Point(427, 109);
            this.reminder.Name = "reminder";
            this.reminder.Size = new System.Drawing.Size(344, 20);
            this.reminder.TabIndex = 2;
            this.reminder.Text = "Please input your Employee\'s ID and Password!";
            this.reminder.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDBox.Location = new System.Drawing.Point(580, 173);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(180, 26);
            this.IDBox.TabIndex = 3;
            this.IDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordBox.Location = new System.Drawing.Point(580, 235);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(180, 26);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ID.Location = new System.Drawing.Point(433, 176);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password.Location = new System.Drawing.Point(433, 238);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 20);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLogin.Location = new System.Drawing.Point(547, 308);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(91, 37);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // programTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(790, 434);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.reminder);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "programTitle";
            this.Text = "Bird Cage Management (Alpha)";
            this.Load += new System.EventHandler(this.programTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label reminder;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button buttonLogin;
    }
}

