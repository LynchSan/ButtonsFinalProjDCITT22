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
    public partial class Form1 : Form
    {

        //Available users and passwords
        Dictionary<string, string> groupM = new Dictionary<string, string>
            {
                { "Aldritch", "A1" },
                { "Beyonce", "B2" },
                { "Danniel", "D3" },
                { "Harvey", "H4" },
                { "Vincent", "V5" },
                { "Johnn", "J6" },
                { "Kenneth", "K7" },
                { "Kylle", "K8" },
                { "Marc", "M9" },
                { "Lynch", "L10" },
                { "Test", "test123" }

            };

        public Form1()
        {
            InitializeComponent();
            this.userInput.KeyDown += userInput_KeyDown; //hook userInput.KeyDown to method userInput_KeyDown 
        }

        //Form 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //User Input textbox
        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }

        //For next InputBox if hit enter
        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                passInput.Focus(); //Move focus to the next TextBox /passInput/
            }
        }

        //Password Input textbox
        private void passInput_TextChanged(object sender, EventArgs e)
        {

        }

        //Login Button
        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputUN = userInput.Text;  // User input for username
            string inputPass = passInput.Text;  // User input for password



            if (!groupM.ContainsKey(inputUN))
            {
                MessageBox.Show($"Username Not Found");
                return;
            }

            //Username associated with the password
            string correctPass = groupM[inputUN];
            if (correctPass != inputPass)
            {
                MessageBox.Show($"Incorrect password!");
                return;
            }

            //Next Form to (MainMenuForm)
            MessageBox.Show("Login successful!");
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();


            this.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
