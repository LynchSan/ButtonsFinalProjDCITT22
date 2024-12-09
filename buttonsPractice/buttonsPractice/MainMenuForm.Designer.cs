namespace buttonsPractice
{
    partial class MainMenuForm
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.pictureArithmetic = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.operationsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snakeButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButtonMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArithmetic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.Aqua;
            this.welcomeText.Location = new System.Drawing.Point(239, 23);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(304, 27);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "WELCOME TO MAIN MENU";
            this.welcomeText.Click += new System.EventHandler(this.welcomeText_Click);
            // 
            // pictureArithmetic
            // 
            this.pictureArithmetic.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_07_214115;
            this.pictureArithmetic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureArithmetic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureArithmetic.Location = new System.Drawing.Point(461, 89);
            this.pictureArithmetic.Name = "pictureArithmetic";
            this.pictureArithmetic.Size = new System.Drawing.Size(170, 103);
            this.pictureArithmetic.TabIndex = 1;
            this.pictureArithmetic.TabStop = false;
            this.pictureArithmetic.Click += new System.EventHandler(this.pictureArithmetic_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkRed;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutButton.Location = new System.Drawing.Point(700, 381);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 27);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // operationsButton
            // 
            this.operationsButton.BackColor = System.Drawing.Color.Cyan;
            this.operationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.operationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsButton.ForeColor = System.Drawing.Color.Black;
            this.operationsButton.Location = new System.Drawing.Point(492, 226);
            this.operationsButton.Name = "operationsButton";
            this.operationsButton.Size = new System.Drawing.Size(101, 26);
            this.operationsButton.TabIndex = 4;
            this.operationsButton.Text = "Operations";
            this.operationsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.operationsButton.UseVisualStyleBackColor = false;
            this.operationsButton.Click += new System.EventHandler(this.operationsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_07_222035;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(109, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 103);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // snakeButton
            // 
            this.snakeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.snakeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.snakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeButton.ForeColor = System.Drawing.Color.Cyan;
            this.snakeButton.Location = new System.Drawing.Point(139, 226);
            this.snakeButton.Name = "snakeButton";
            this.snakeButton.Size = new System.Drawing.Size(110, 26);
            this.snakeButton.TabIndex = 6;
            this.snakeButton.Text = "SnakeGame";
            this.snakeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.snakeButton.UseVisualStyleBackColor = false;
            this.snakeButton.Click += new System.EventHandler(this.snakeButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aboutButton.Location = new System.Drawing.Point(24, 411);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(92, 27);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "About us";
            this.aboutButton.UseVisualStyleBackColor = false;
            // 
            // exitButtonMain
            // 
            this.exitButtonMain.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButtonMain.Location = new System.Drawing.Point(721, 414);
            this.exitButtonMain.Name = "exitButtonMain";
            this.exitButtonMain.Size = new System.Drawing.Size(52, 27);
            this.exitButtonMain.TabIndex = 8;
            this.exitButtonMain.Text = "Exit";
            this.exitButtonMain.UseVisualStyleBackColor = false;
            this.exitButtonMain.Click += new System.EventHandler(this.exitButtonMain_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_07_212509;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButtonMain);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.snakeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.operationsButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.pictureArithmetic);
            this.Controls.Add(this.welcomeText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "MainMenuForm";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArithmetic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.PictureBox pictureArithmetic;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button operationsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button snakeButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButtonMain;
    }
}