namespace buttonsPractice
{
    partial class Arithmetic
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
            this.enterNum1A = new System.Windows.Forms.TextBox();
            this.enterNum2A = new System.Windows.Forms.TextBox();
            this.labelEnterNum1 = new System.Windows.Forms.Label();
            this.labelEnterNum2A = new System.Windows.Forms.Label();
            this.arithmeticButtonAll = new System.Windows.Forms.Button();
            this.mainMenuArithmetic = new System.Windows.Forms.Button();
            this.exitButtonArithmetic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterNum1A
            // 
            this.enterNum1A.BackColor = System.Drawing.Color.Black;
            this.enterNum1A.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNum1A.ForeColor = System.Drawing.Color.Lime;
            this.enterNum1A.Location = new System.Drawing.Point(158, 140);
            this.enterNum1A.Name = "enterNum1A";
            this.enterNum1A.Size = new System.Drawing.Size(106, 28);
            this.enterNum1A.TabIndex = 0;
            this.enterNum1A.TextChanged += new System.EventHandler(this.enterNum1A_TextChanged);
            // 
            // enterNum2A
            // 
            this.enterNum2A.BackColor = System.Drawing.Color.Black;
            this.enterNum2A.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNum2A.ForeColor = System.Drawing.Color.Lime;
            this.enterNum2A.Location = new System.Drawing.Point(475, 140);
            this.enterNum2A.Name = "enterNum2A";
            this.enterNum2A.Size = new System.Drawing.Size(106, 28);
            this.enterNum2A.TabIndex = 1;
            this.enterNum2A.TextChanged += new System.EventHandler(this.enterNum2A_TextChanged);
            // 
            // labelEnterNum1
            // 
            this.labelEnterNum1.AutoSize = true;
            this.labelEnterNum1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnterNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNum1.ForeColor = System.Drawing.Color.Cyan;
            this.labelEnterNum1.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelEnterNum1.Location = new System.Drawing.Point(142, 105);
            this.labelEnterNum1.Name = "labelEnterNum1";
            this.labelEnterNum1.Size = new System.Drawing.Size(154, 20);
            this.labelEnterNum1.TabIndex = 2;
            this.labelEnterNum1.Text = "Enter first number";
            this.labelEnterNum1.Click += new System.EventHandler(this.labelEnterNum1_Click);
            // 
            // labelEnterNum2A
            // 
            this.labelEnterNum2A.AutoSize = true;
            this.labelEnterNum2A.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnterNum2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNum2A.ForeColor = System.Drawing.Color.Cyan;
            this.labelEnterNum2A.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_213159;
            this.labelEnterNum2A.Location = new System.Drawing.Point(448, 105);
            this.labelEnterNum2A.Name = "labelEnterNum2A";
            this.labelEnterNum2A.Size = new System.Drawing.Size(181, 20);
            this.labelEnterNum2A.TabIndex = 3;
            this.labelEnterNum2A.Text = "Enter second number";
            // 
            // arithmeticButtonAll
            // 
            this.arithmeticButtonAll.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131211;
            this.arithmeticButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arithmeticButtonAll.ForeColor = System.Drawing.Color.Cyan;
            this.arithmeticButtonAll.Location = new System.Drawing.Point(311, 209);
            this.arithmeticButtonAll.Name = "arithmeticButtonAll";
            this.arithmeticButtonAll.Size = new System.Drawing.Size(101, 42);
            this.arithmeticButtonAll.TabIndex = 4;
            this.arithmeticButtonAll.Text = "Arithmetic";
            this.arithmeticButtonAll.UseVisualStyleBackColor = true;
            // 
            // mainMenuArithmetic
            // 
            this.mainMenuArithmetic.BackColor = System.Drawing.Color.Black;
            this.mainMenuArithmetic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuArithmetic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenuArithmetic.Location = new System.Drawing.Point(12, 398);
            this.mainMenuArithmetic.Name = "mainMenuArithmetic";
            this.mainMenuArithmetic.Size = new System.Drawing.Size(47, 40);
            this.mainMenuArithmetic.TabIndex = 9;
            this.mainMenuArithmetic.Text = "<";
            this.mainMenuArithmetic.UseVisualStyleBackColor = false;
            this.mainMenuArithmetic.Click += new System.EventHandler(this.mainMenuArithmetic_Click);
            // 
            // exitButtonArithmetic
            // 
            this.exitButtonArithmetic.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonArithmetic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonArithmetic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButtonArithmetic.Location = new System.Drawing.Point(736, 411);
            this.exitButtonArithmetic.Name = "exitButtonArithmetic";
            this.exitButtonArithmetic.Size = new System.Drawing.Size(52, 27);
            this.exitButtonArithmetic.TabIndex = 10;
            this.exitButtonArithmetic.Text = "Exit";
            this.exitButtonArithmetic.UseVisualStyleBackColor = false;
            this.exitButtonArithmetic.Click += new System.EventHandler(this.exitButtonArithmetic_Click);
            // 
            // Arithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_213159;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButtonArithmetic);
            this.Controls.Add(this.mainMenuArithmetic);
            this.Controls.Add(this.arithmeticButtonAll);
            this.Controls.Add(this.labelEnterNum2A);
            this.Controls.Add(this.labelEnterNum1);
            this.Controls.Add(this.enterNum2A);
            this.Controls.Add(this.enterNum1A);
            this.DoubleBuffered = true;
            this.Name = "Arithmetic";
            this.Text = "Arithmetic";
            this.Load += new System.EventHandler(this.Arithmetic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterNum1A;
        private System.Windows.Forms.TextBox enterNum2A;
        private System.Windows.Forms.Label labelEnterNum1;
        private System.Windows.Forms.Label labelEnterNum2A;
        private System.Windows.Forms.Button arithmeticButtonAll;
        private System.Windows.Forms.Button mainMenuArithmetic;
        private System.Windows.Forms.Button exitButtonArithmetic;
    }
}