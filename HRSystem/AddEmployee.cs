using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text == "" || fullnameTextbox.Text == "" || emailTextbox.Text == "" || genderTextbox.Text == ""
                || ageTextbox.Text == "" || addressTextbox.Text == "" || numberTextbox.Text == "" || jobTextbox.Text == ""
                || companyTextbox.Text == "")
            {
                MessageBox.Show("Please Enter All Fields");
            } else
            {
                int age = Convert.ToInt32(ageTextbox.Text.ToString());
                employeeTableAdapter.AddEmployee(usernameTextbox.Text, fullnameTextbox.Text, emailTextbox.Text,
                    genderTextbox.Text, age, addressTextbox.Text, numberTextbox.Text,
                    jobTextbox.Text, companyTextbox.Text);
                this.Close();

                // we need to update table when form closed
            }
        }
    }
}
