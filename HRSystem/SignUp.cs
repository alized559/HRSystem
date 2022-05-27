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

        private void SignUp_Load(object sender, EventArgs e)
        {
            passwordShow.ImageLocation = @"../../Images/eyeShow.jpg";
            password2Show.ImageLocation = @"../../Images/eyeShow.jpg";
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (fullnameTextbox.Text == "" || emailTextbox.Text == "" || passwordTextbox.Text == "" ||
                password2Textbox.Text == "")
            {
                errorText.Text = "Please Enter All Fields";
                errorText.Visible = true;
            }
            else if (passwordTextbox.Text.Length < 6)
            {
                errorText.Text = "Password Must Be Strong";
                errorText.Visible = true;
                clearPassword();
            }
            else if (passwordTextbox.Text != password2Textbox.Text)
            {
                errorText.Text = "Password Doesn't Match";
                errorText.Visible = true;
                clearPassword();
            }
            else
            {
                // check if email exists else success
                string conn = "Data Source=DESKTOP-KING\\SQLEXPRESS;Initial Catalog=HRSystem;Integrated Security=True";
                SqlConnection connection = new SqlConnection(conn);
                string query = "SELECT * FROM admin WHERE email = '" + emailTextbox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        errorText.Text = "Email Already Exists";
                        errorText.Visible = true;
                        clearAllFields();
                    }
                    else
                    {
                        //success
                    }
                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        private void passwordShow_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.UseSystemPasswordChar)
            {
                passwordShow.ImageLocation = @"../../Images/eyeHide.jpg";
                passwordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordShow.ImageLocation = @"../../Images/eyeShow.jpg";
                passwordTextbox.UseSystemPasswordChar = true;
            }
        }

        private void password2Show_Click(object sender, EventArgs e)
        {
            if (password2Textbox.UseSystemPasswordChar)
            {
                password2Show.ImageLocation = @"../../Images/eyeHide.jpg";
                password2Textbox.UseSystemPasswordChar = false;
            }
            else
            {
                password2Show.ImageLocation = @"../../Images/eyeShow.jpg";
                password2Textbox.UseSystemPasswordChar = true;
            }
        }

        private void loginLink_Click(object sender, EventArgs e)
        {

        }

        private void clearAllFields()
        {
            fullnameTextbox.Clear();
            emailTextbox.Clear();
            passwordTextbox.Clear();
            password2Textbox.Clear();
        }

        private void clearPassword()
        {
            passwordTextbox.Clear();
            password2Textbox.Clear();
        }
    }
}
