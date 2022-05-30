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
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (titleTextbox.Text == "" || workplaceTextbox.Text == "" || locationTextbox.Text == "" || typeTextbox.Text == ""
                || descriptionTextbox.Text == "")
            {
                MessageBox.Show("Please Enter All Fields");
            } else
            {
                jobTableAdapter.AddJobPost(titleTextbox.Text, workplaceTextbox.Text, locationTextbox.Text, typeTextbox.Text,
                    descriptionTextbox.Text);
                this.Close();
            }
        }
    }
}
