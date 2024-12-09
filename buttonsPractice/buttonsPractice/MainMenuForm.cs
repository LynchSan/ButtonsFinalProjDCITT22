using Snake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonsPractice
{
    public partial class MainMenuForm : Form
    {
        private string username;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void operationsButton_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            operations.Show();
            this.Close();
        }

        private void snakeButton_Click(object sender, EventArgs e)
        {
            SnakeForm snakeForm = new SnakeForm();
            snakeForm.Show();
            this.Close();

        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }

        private void pictureArithmetic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        //Adding Exit so It doesn't run on background cause it's annoying.
        private void exitButtonMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
