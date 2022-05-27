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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            passwordShow.ImageLocation = @"../../Images/eyeShow.jpg";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "" || passwordTextbox.Text == "")
            {
                errorText.Text = "Please Enter All Fields";
                errorText.Visible = true;
            }
            else if (passwordTextbox.Text.Length < 6)
            {
                errorText.Text = "Password Must Be Strong";
                errorText.Visible = true;
                passwordTextbox.Clear();
            }
            else
            {
                // check if email exists else success
                string conn = "Data Source=DESKTOP-KING\\SQLEXPRESS;Initial Catalog=HRSystem;Integrated Security=True";
                SqlConnection connection = new SqlConnection(conn);
                string query = "SELECT * FROM admin WHERE email = '" + emailTextbox.Text + "' AND password = '" + 
                    passwordTextbox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //success
                    }
                    else
                    {
                        errorText.Text = "Account Not Found";
                        errorText.Visible = true;
                        emailTextbox.Clear();
                        passwordTextbox.Clear();
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
    }
}
