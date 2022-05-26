using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (fullnameTextbox.Text == "" || emailTextbox.Text == "" || passwordTextbox.Text == "" || 
                password2Textbox.Text == "")
            {
                errorText.Text = "Please Enter All Fields";
                errorText.Visible = true;
            } else if (passwordTextbox.Text.Length < 6)
            {
                errorText.Text = "Password Must Be Strong";
                errorText.Visible = true;
            } else if (passwordTextbox.Text != password2Textbox.Text)
            {
                errorText.Text = "Password Doesn't Match";
                errorText.Visible = true;
            } else
            {
                
            }
        }

        private void loginLink_Click(object sender, EventArgs e)
        {

        }
    }
}
