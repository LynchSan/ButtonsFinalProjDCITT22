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
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();

        }


        //For proper closing the main form since i just hide it and it annoys me when it runs on the background hiddenly.
        private void operationsForm_Closing(object sender, FormClosingEventArgs e)
        {
            // Ensure the main form is also closed when this form is closed
            if (this.Owner != null && this.Owner is Form mainForm)
            {
                mainForm.Close(); // Close the main form
            }
        }


        private void arithmeticButton_Click(object sender, EventArgs e)
        {
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.Show();
            this.Close();
        }

        private void mainMenu2_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void exitButtonOperations_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
