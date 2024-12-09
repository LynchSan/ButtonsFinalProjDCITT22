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
    public partial class Arithmetic : Form
    {
        public Arithmetic()
        {
            InitializeComponent();
            this.enterNum1A.KeyDown += enterNum1A_KeyDown; //hook userInput.KeyDown to method userInput_KeyDown 
        }

        //For proper closing the main form since i just hide it and it annoys me when it runs on the background hiddenly.
        private void arithmeticForm_Closing(object sender, FormClosingEventArgs e)
        {
            // Ensure the main form is also closed when this form is closed
            if (this.Owner != null && this.Owner is Form mainForm)
            {
                mainForm.Close(); // Close the main form
            }
        }


        private void Arithmetic_Load(object sender, EventArgs e)
        {

        }

        private void enterNum1A_TextChanged(object sender, EventArgs e)
        {

        }

        //For next InputBox if hit enter
        private void enterNum1A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                enterNum2A.Focus(); //Move focus to the next TextBox /passInput/
            }
        }

        private void labelEnterNum1_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuArithmetic_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void enterNum2A_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButtonArithmetic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
